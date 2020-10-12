// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.


namespace Eco.Mods.TechTree
{
    using System;
    using System.ComponentModel;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Plants;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Simulation;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.GameActions;
    using Eco.Shared.Serialization;
    using Eco.Core.Items;

    [Category("Hidden"), Tag("Excavation"), Tag("Harvester")]
    [CarryTypesLimited]
    public partial class ShovelItem : ToolItem, IPerformsToolAction
    {
        private static SkillModifiedValue caloriesBurn = CreateCalorieValue(20, typeof(SelfImprovementSkill), typeof(ShovelItem), new ShovelItem().UILink());
        public override IDynamicValue CaloriesBurn            { get { return caloriesBurn; } }
        public override ClientPredictedBlockAction LeftAction { get { return ClientPredictedBlockAction.PickupBlock; } }
        public override LocString LeftActionDescription       { get { return Localizer.DoStr("Dig"); } }

        static IDynamicValue tier = new ConstantValue(0);
        public override IDynamicValue Tier                    { get { return tier; } }
        private static IDynamicValue skilledRepairCost        = new ConstantValue(1);
        public override IDynamicValue SkilledRepairCost       { get { return skilledRepairCost; } }

        public override int FullRepairAmount                  { get { return 1; } }
        public override int MaxTake                           { get { return 1; } }
        public override bool ShouldHighlight(Type block)      { return Block.Is<Diggable>(block); }
        public ToolInteractAction MakeAction(ToolActionType tool) => new DigOrMine();

        public override InteractResult OnActLeft(InteractionContext context)
        {
            if (context.HasBlock)
            {
                if (context.Block is PlantBlock)
                {
                    var plant = EcoSim.PlantSim.GetPlant(context.BlockPosition.Value);
                    if (plant != null && plant is PlantEntity harvestable)
                    {
                        Result result;
                        using (var pack = new GameActionPack())
                        {
                            var changeSet = pack.GetOrCreateChangeSet(context.Player.User.Inventory, context.Player.User);
                            harvestable.TryHarvest(context.Player, true, pack, changeSet, this);
                            result = pack.TryPerform(false);
                        }

                        if (result.Success)
                            this.BurnCaloriesNow(context.Player);
                        return (InteractResult)result;
                    }
                    else
                    {
                        using (var pack = new GameActionPack())
                        {
                            pack.DeleteBlock(context.BlockPosition.Value, context.Player, false, null, this);
                            pack.UseTool(context.Player, this);
                            return (InteractResult)pack.TryPerform(false);
                        }
                    }
                }
                else if (context.Block.Is<Diggable>())
                {
                    if (TreeEntity.TreeRootsBlockDigging(context))
                        return InteractResult.Failure(Localizer.DoStr("You attempt to dig up the soil, but the roots are too strong!"));

                    // Destroy the plant and the block, adding to inventory.
                    var pack = new GameActionPack();
                    pack.PrepareMultiblockToolAction(this, context, (blockPos, actionPack) =>
                    {
                        actionPack.DestroyPlant(context.Player, blockPos.Pos + Vector3i.Up, this, DeathType.Construction);
                        actionPack.DeleteBlock(blockPos.Pos, context.Player, true, new DirtItem(), this);
                        return true;
                    }, null, LocString.Empty);

                    return (InteractResult)pack.TryPerform(false);
                }
            }

            if (context.Target is WorldObject) return this.BasicToolOnWorldObjectCheck(context);

            return base.OnActLeft(context);
        }
    }
}
