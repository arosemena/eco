// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
namespace Eco.Mods.TechTree
{
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Shared.Serialization;
    using Eco.Shared.Networking;
    using Eco.Gameplay.Players;
    using Eco.Simulation;
    using Eco.Gameplay.Animals;
    using Eco.Gameplay.Utils;
    using Eco.Shared.Localization;

    //this is going to be a real item at some point

    [Serialized]
    [LocDisplayName("Fishing Pole")]
    [Weight(1000)]
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class FishingPoleItem : ToolItem
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A wooden pole attached to a line and hook. Used to catch fish from rivers and the ocean."); } }

        private static IDynamicValue caloriesBurn = new ConstantValue(1.0f);

        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(10, HuntingSkill.MultiplicativeStrategy, typeof(HuntingSkill), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency);
        public override IDynamicValue SkilledRepairCost { get { return skilledRepairCost; } }

        static FishingPoleItem() { }

        public override IDynamicValue CaloriesBurn { get { return caloriesBurn; } }
       
        [RPC]
        void FinalizeCatch(Player player, INetObject target)
        {
            if (!(target is AnimalEntity animal)) return;

            animal.Destroy();

            var resourceType = animal.Species.ResourceItemType;
            if (resourceType == null || !player.User.Inventory.TryAddItem(resourceType, player.User).Notify(player)) return;
            animal.Kill();
        }

        [RPC]
        void Release(INetObject target)
        {
            if (target is AnimalEntity animal) animal.Destroy();
        }
    }

    public class LureEntity : NetPhysicsEntity
    {
        public LureEntity() : base("Lure") { }

        public override bool IsNotRelevant(INetObjectViewer viewer)
        {
            bool isNot = base.IsNotRelevant(viewer);
            if (this.Controller == null)
                this.Destroy();

            return isNot;
        }

        public override void ReceiveUpdate(BSONObject bsonObj)
        {
            base.ReceiveUpdate(bsonObj);

            if (this.Position.y <= 0)
                this.Destroy();
        }
    }

}
