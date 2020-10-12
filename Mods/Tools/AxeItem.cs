// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

#nullable enable
namespace Eco.Mods.TechTree
{
    using System;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Plants;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Simulation;
    using Eco.Simulation.Types;
    using Eco.Stats;
    using Eco.World;
    using Eco.World.Blocks;

    [Category("Hidden"), Tag("Logging")]
    public partial class AxeItem
    {
        static IDynamicValue caloriesBurn = new ConstantValue(0);
        static IDynamicValue damage = new ConstantValue(100);
        static IDynamicValue tier = new ConstantValue(0);
        static IDynamicValue skilledRepairCost = new ConstantValue(1);

        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override Type ExperienceSkill => typeof(LoggingSkill);

        public override Item RepairItem => Item.Get<StoneItem>();
        public override int FullRepairAmount => 1;

        public override IDynamicValue CaloriesBurn => caloriesBurn;
        public override IDynamicValue Damage => damage;
        public override IDynamicValue Tier => tier;

        public override LocString LeftActionDescription => Localizer.DoStr("Chop");

        public override bool IsValidFor(Item item) => item is LogItem;

        public override InteractResult OnActLeft(InteractionContext context)
        {
            if (context.HasBlock)
            {
                var block = World.GetBlock(context.BlockPosition!.Value);
                if (block.Is<TreeDebris>() || block.Is<Chopable>())
                {
                    using (var changes = new InventoryChangeSet(context.Player!.User.Inventory, context.Player.User))
                    {
                        var pack = new GameActionPack();
                        pack.PrepareMultiblockToolAction(this, context, (blockPos, actionPack) =>
                            {
                                var treeDebris = World.GetBlock(blockPos.Pos).Get<TreeDebris>();
                                if (treeDebris != null)
                                {
                                    var species = EcoSim.GetSpecies(treeDebris.Species) as TreeSpecies;
                                    foreach (var x in species!.DebrisResources)
                                        changes.AddItems(x.Key, x.Value.RandInt);

                                    actionPack.DeleteBlock(blockPos.Pos, context.Player, false, null, this);

                                    actionPack.AddGameAction(new CleanupTreeDebris()
                                    {
                                        Citizen = context.Player?.User,
                                        Location = context.BlockPosition.Value,
                                        ToolUsed = this,
                                    });
                                    return true;
                                }

                                return false;
                            },
                            this.GetCaloriesMultiplier,
                            Localizer.DoStr("removing tree debris"), 0.1f);

                        if (pack.EarlyResult.Success) pack.AddChangeSet(changes);

                        return (InteractResult)pack.TryPerform(false);
                    }
                }
                return InteractResult.NoOp;
            }

            if (context.Target is WorldObject) return this.BasicToolOnWorldObjectCheck(context);

            return base.OnActLeft(context);
        }

        private float GetCaloriesMultiplier(User? user, Block? block)
        {
            var isDebris = block?.Is<TreeDebris>() ?? false;
            if (isDebris)
                return user != null && user.Talentset.HasTalent<LoggingCleanupCrewTalent>() ? 1f : 3f;

            return 1f;
        }

        public override bool ShouldHighlight(Type block) => Block.Is<TreeDebris>(block);
    }
}
