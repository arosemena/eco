// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Plants;
    using Eco.Gameplay.Players;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation;
    using Eco.World;

    // Wrapper for tools like sickle and scythe, contains same code
    public abstract partial class BlockHarvestItem : ToolItem
    {
        public override ClientPredictedBlockAction LeftAction => ClientPredictedBlockAction.Harvest;

        public override LocString LeftActionDescription => Localizer.DoStr("Reap");

        public override bool ShouldHighlight(Type block) => Block.Is<Reapable>(block);

        public override InteractResult OnActLeft(InteractionContext context)
        {
            if (context.HasBlock && context.Block.Is<Reapable>())
            {
                using (var changes = new InventoryChangeSet(context.Player!.User.Inventory, context.Player.User))
                {
                    var pack = new GameActionPack();
                    pack.PrepareMultiblockToolAction(this, context, (blockPos, actionPack) =>
                            this.HarvestBlock(blockPos.Block, blockPos.Pos, context.Player, actionPack, changes),
                        null, LocString.Empty);

                    if (pack.EarlyResult.Success) pack.AddChangeSet(changes);

                    return (InteractResult)pack.TryPerform(false);
                }
            }

            if (context.Target is WorldObject) return this.BasicToolOnWorldObjectCheck(context);

            return base.OnActLeft(context);
        }

        protected virtual bool HarvestBlock(Block block, Vector3i pos, Player player, GameActionPack pack, InventoryChangeSet changeSet)
        {
            if (EcoSim.PlantSim.GetPlant(pos) is PlantEntity plant && plant.CanScythe(player))
            {
                if (block.Is<Reapable>() && plant.TryHarvest(player, true, pack, changeSet, this))
                {
                    pack.AddPostEffect(() => player.SpawnBlockEffect(pos, block.GetType(), BlockEffect.Harvest, player.Position));
                    return true;
                }
            }

            return false;
        }
    }
}
