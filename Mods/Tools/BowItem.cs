﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Core.Items;
    using Eco.Gameplay.Animals;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Simulation.Agents;

    [Tag("Harvester")]
    public partial class BowItem
    {
        private static readonly SkillModifiedValue CaloriesBurnValue;
        private static readonly SkillModifiedValue DamageValue;

        static BowItem()
        {
            string bowUiLink = new BowItem().UILink();
            CaloriesBurnValue = CreateCalorieValue(20, typeof(HuntingSkill), typeof(BowItem), new LocString(bowUiLink));
            DamageValue = CreateDamageValue(1, typeof(HuntingSkill), typeof(BowItem), new LocString(bowUiLink));
        }
        
        private static readonly IDynamicValue SkilledRepairCostValue = new ConstantValue(5);
        public override IDynamicValue SkilledRepairCost => SkilledRepairCostValue;

        public override IDynamicValue CaloriesBurn      => CaloriesBurnValue;
        public override IDynamicValue Damage => DamageValue;
        public override Type ExperienceSkill            => typeof(HuntingSkill);
        private static readonly IDynamicValue Exp       = new ConstantValue(1f);
        public override IDynamicValue ExperienceRate    => Exp;
        public override Tag RepairTag                   => TagManager.Tag("Log");
        public override int FullRepairAmount            => 5;
        protected virtual Type ToolType                 => typeof(BowItem);

        [RPC]
        public int FireArrow(Player player, Vector3 position, Vector3 velocity)
        {
            using (var pack = new GameActionPack())
            {
                if (player.User.Inventory.TryRemoveItem<ArrowItem>(player.User))
                {
                    pack.UseTool(player, this);
                    if (pack.TryPerform())
                    {
                        var arrow = new ArrowEntity
                        {
                            Damage = this.Damage.GetCurrentValue(player.User), Controller = player, Position = position,
                            Velocity = velocity,
                            BowType = this.GetType()
                        };
                        arrow.SetActiveAndCreate();
                        return arrow.ID;
                    }
                }
            }
            return -1;
        }

        public override bool ShouldHighlight(Type block)
        {
            return false;
        }
    }

    public class ArrowEntity : NetEntity, IDetectHarvest
    {
        public Type BowType { get; set; }
        public float Damage { get; set; }
        public INetObjectViewer Controller { get; set; }
        public Vector3 Velocity { get; set; }
        public NetObjAttachInfo Attached;
        private readonly double destroyTime;
    private const double LifeTime = 120f;

        public ArrowEntity()
            : base("Arrow")
        {
            this.destroyTime = TimeUtil.Seconds + LifeTime;
        }

        

        [RPC]
        public override void Destroy()
        {
            // let clients help decide when to destroy
            base.Destroy();
        }

        [RPC]
        public void Hit(NetObjAttachInfo hitAttachInfo, Vector3 position, string location)
        {
            var player  = this.Controller as Player;
            if (player == null) return;

            var target = NetObjectManager.GetObject<INetObject>(hitAttachInfo.ParentID);

            // bow only damages animals // Auth will be checked inside TryApplyDamage via HarvestOrHunt. Other cases are harmless.
            if (target is AnimalEntity targetAnimal)
            {
                targetAnimal.AttachedEntities.Add(this);
                var tool = Item.Get(this.BowType);
                var locationMultiplier = location.Contains("Head")
                    ? (player.User.Talentset.HasTalent(typeof(HuntingDeadeyeTalent)) ? 4 : 2)
                    : 1;
                if (targetAnimal.Dead || targetAnimal.TryApplyDamage(player, this.Damage * locationMultiplier, 
                        new InteractionContext() {SelectedItem = tool }, tool, typeof(ArrowItem)))
                    this.Attached = hitAttachInfo;
                else
                    this.Destroy();                    
            }
            else if (target is Player targetPlayer)
            {
                // arrows look silly sticking in player capsule colliders
                player.ErrorLoc($"You must obtain authorization to shoot {targetPlayer.User.MarkedUpName}.");
                this.Destroy();
            }
            else
                this.Attached = hitAttachInfo;

            Animal.AlertNearbyAnimals(this.Position, 15f);

            if (this.Attached != null)
                this.RPC("Attach", this.Attached);

            this.Position = position;
            this.Rotation = Quaternion.LookRotation(this.Velocity.Normalized);
            this.Velocity = Vector3.Zero;
        }

        [RPC]
        public void HitStatic(Vector3 position, Quaternion rotation)
        {
            this.Position = position;
            this.Rotation = rotation;
            this.Velocity = Vector3.Zero;
            this.RPC("Attach", position, rotation);
            Animal.AlertNearbyAnimals(this.Position, 15f);
        }

        public override bool IsRelevant(INetObjectViewer viewer)
        {
            if (this.Attached != null)
            {
                var obj = NetObjectManager.GetObject<INetObject>(this.Attached.ParentID);
                if (obj != null)
                    return obj.IsRelevant(viewer);

                this.Destroy();
                return false;
            }

            return base.IsRelevant(viewer);
        }

        public override bool IsNotRelevant(INetObjectViewer viewer)
        {
            if (TimeUtil.Seconds > this.destroyTime)
                this.Destroy();

            if (this.Attached != null)
            {
                var obj = NetObjectManager.GetObject<INetObject>(this.Attached.ParentID);
                if (obj != null)
                    return obj.IsNotRelevant(viewer);

                this.Destroy();
                return true;
            }

            return base.IsNotRelevant(viewer);
        }

        public override void SendUpdate(BSONObject bsonObj, INetObjectViewer viewer)
        {
            if (this.Attached == null)
                base.SendUpdate(bsonObj, viewer);
        }

        public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer)
        {
            base.SendInitialState(bsonObj, viewer);
            if (this.Attached != null)
                bsonObj["attached"] = this.Attached.ToBson();
            bsonObj["v"] = this.Velocity;
            if (this.Controller != null && this.Controller is INetObject)
                bsonObj["controller"] = ((INetObject) this.Controller).ID;
        }

        public void OnHarvest(Player player)
        {
            if (player != null && player.User.Talentset.HasTalent(typeof(HuntingArrowRecoveryTalent)))
                player.User.Inventory.TryAddItems(typeof(ArrowItem), 1);
        }
    }
}
