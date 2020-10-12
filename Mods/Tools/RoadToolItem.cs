// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
namespace Eco.Mods.TechTree
{
    using System;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.GameActions;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Simulation;
    using Eco.World;
    using Eco.World.Blocks;

    [Category("Hidden"), Tag("Tamper")]
    public abstract partial class RoadToolItem : ToolItem, IPerformsToolAction
    {
        public ToolInteractAction MakeAction(ToolActionType tool) => new TampRoad();

        public override LocString LeftActionDescription { get { return Localizer.DoStr("Build road"); } }

        public override InteractResult OnActLeft(InteractionContext context)
        {
            if (context.HasBlock)
            {
                if (TreeEntity.TreeRootsBlockDigging(context))
                    return InteractResult.Failure(Localizer.DoStr("You attempt to make a road, but the roots are too strong!"));
                if (context.Block.Is<Road>())
                    return InteractResult.Failure(LocString.Empty);

                var blockType = this.GetRoadBlock(context.Block);
                if (blockType != null)
                {
                    var pack = new GameActionPack();
                    pack.PrepareMultiblockToolAction(this, context, (blockPos, actionPack) =>
                    {
                        actionPack.DestroyPlant(context.Player, blockPos.Pos + Vector3i.Up, this, DeathType.Construction);
                        actionPack.PlaceBlock(blockType, blockPos.Pos, context.Player, true, null, false, this);
                        return true;
                    }, null, LocString.Empty);

                    return (InteractResult)pack.TryPerform(false);
                }
                else
                    return InteractResult.NoOp;
            }

            if (context.Target is WorldObject) return this.BasicToolOnWorldObjectCheck(context);

            return base.OnActLeft(context);
        }

        /// <summary> Returns type of Road block which may be created from <see cref="currentBlock"/>. </summary>
        private Type GetRoadBlock(Block currentBlock) => currentBlock.Is<CanBeRoad>() ? typeof(DirtRoadBlock) : null;
    }
}
