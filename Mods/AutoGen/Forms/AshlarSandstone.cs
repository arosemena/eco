﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloorFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFloorBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WallFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FullWallFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFullWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FlatRoofFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFlatRoofBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(CubeFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ColumnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WindowFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FenceFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFenceBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ChimneyFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneChimneyBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(DoubleWindowFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneDoubleWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderPeakSetFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(PeakSetFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstonePeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakSetFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCubeFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AshlarSandstoneItem); } }
    }



    [RotatedVariants(typeof(AshlarSandstoneRampABlock), typeof(AshlarSandstoneRampA90Block), typeof(AshlarSandstoneRampA180Block), typeof(AshlarSandstoneRampA270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampAFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRampABlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampA90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampA180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampA270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRampBBlock), typeof(AshlarSandstoneRampB90Block), typeof(AshlarSandstoneRampB180Block), typeof(AshlarSandstoneRampB270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampBFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRampBBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampB90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampB180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampB270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRampCBlock), typeof(AshlarSandstoneRampC90Block), typeof(AshlarSandstoneRampC180Block), typeof(AshlarSandstoneRampC270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampCFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRampCBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampC90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampC180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampC270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRampDBlock), typeof(AshlarSandstoneRampD90Block), typeof(AshlarSandstoneRampD180Block), typeof(AshlarSandstoneRampD270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampDFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRampDBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampD90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampD180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRampD270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneLadderBlock), typeof(AshlarSandstoneLadder90Block), typeof(AshlarSandstoneLadder180Block), typeof(AshlarSandstoneLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(LadderFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneLadderBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneLadder90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneLadder180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneLadder270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneStairsBlock), typeof(AshlarSandstoneStairs90Block), typeof(AshlarSandstoneStairs180Block), typeof(AshlarSandstoneStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairs270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderStairsBlock), typeof(AshlarSandstoneUnderStairs90Block), typeof(AshlarSandstoneUnderStairs180Block), typeof(AshlarSandstoneUnderStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderStairsFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderStairs270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneFloatStairsBlock), typeof(AshlarSandstoneFloatStairs90Block), typeof(AshlarSandstoneFloatStairs180Block), typeof(AshlarSandstoneFloatStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFloatStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairs270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBraceBlock), typeof(AshlarSandstoneBrace90Block), typeof(AshlarSandstoneBrace180Block), typeof(AshlarSandstoneBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BraceFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBrace270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderBraceBlock), typeof(AshlarSandstoneUnderBrace90Block), typeof(AshlarSandstoneUnderBrace180Block), typeof(AshlarSandstoneUnderBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderBraceFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBrace270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneSideBraceBlock), typeof(AshlarSandstoneSideBrace90Block), typeof(AshlarSandstoneSideBrace180Block), typeof(AshlarSandstoneSideBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(SideBraceFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneSideBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneSideBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneSideBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneSideBrace270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBasicSlopeSideBlock), typeof(AshlarSandstoneBasicSlopeSide90Block), typeof(AshlarSandstoneBasicSlopeSide180Block), typeof(AshlarSandstoneBasicSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeSideFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBasicSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBasicSlopeCornerBlock), typeof(AshlarSandstoneBasicSlopeCorner90Block), typeof(AshlarSandstoneBasicSlopeCorner180Block), typeof(AshlarSandstoneBasicSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBasicSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBasicSlopeTurnBlock), typeof(AshlarSandstoneBasicSlopeTurn90Block), typeof(AshlarSandstoneBasicSlopeTurn180Block), typeof(AshlarSandstoneBasicSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBasicSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBasicSlopePointBlock), typeof(AshlarSandstoneBasicSlopePoint90Block), typeof(AshlarSandstoneBasicSlopePoint180Block), typeof(AshlarSandstoneBasicSlopePoint270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopePointFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBasicSlopePointBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopePoint90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopePoint180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBasicSlopePoint270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneFloatStairsCornerBlock), typeof(AshlarSandstoneFloatStairsCorner90Block), typeof(AshlarSandstoneFloatStairsCorner180Block), typeof(AshlarSandstoneFloatStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFloatStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneFloatStairsTurnBlock), typeof(AshlarSandstoneFloatStairsTurn90Block), typeof(AshlarSandstoneFloatStairsTurn180Block), typeof(AshlarSandstoneFloatStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneFloatStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneFloatStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneStairsCornerBlock), typeof(AshlarSandstoneStairsCorner90Block), typeof(AshlarSandstoneStairsCorner180Block), typeof(AshlarSandstoneStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneStairsTurnBlock), typeof(AshlarSandstoneStairsTurn90Block), typeof(AshlarSandstoneStairsTurn180Block), typeof(AshlarSandstoneStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderBraceCornerBlock), typeof(AshlarSandstoneUnderBraceCorner90Block), typeof(AshlarSandstoneUnderBraceCorner180Block), typeof(AshlarSandstoneUnderBraceCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderBraceCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderBraceCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBraceCornerBlock), typeof(AshlarSandstoneBraceCorner90Block), typeof(AshlarSandstoneBraceCorner180Block), typeof(AshlarSandstoneBraceCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BraceCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBraceCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderSlopeSideBlock), typeof(AshlarSandstoneUnderSlopeSide90Block), typeof(AshlarSandstoneUnderSlopeSide180Block), typeof(AshlarSandstoneUnderSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeSideFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderSlopeCornerBlock), typeof(AshlarSandstoneUnderSlopeCorner90Block), typeof(AshlarSandstoneUnderSlopeCorner180Block), typeof(AshlarSandstoneUnderSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderSlopeTurnBlock), typeof(AshlarSandstoneUnderSlopeTurn90Block), typeof(AshlarSandstoneUnderSlopeTurn180Block), typeof(AshlarSandstoneUnderSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderSlopePeakBlock), typeof(AshlarSandstoneUnderSlopePeak90Block), typeof(AshlarSandstoneUnderSlopePeak180Block), typeof(AshlarSandstoneUnderSlopePeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopePeakFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderSlopePeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopePeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopePeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderSlopePeak270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRoofSideBlock), typeof(AshlarSandstoneRoofSide90Block), typeof(AshlarSandstoneRoofSide180Block), typeof(AshlarSandstoneRoofSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofSideFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofSide270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRoofTurnBlock), typeof(AshlarSandstoneRoofTurn90Block), typeof(AshlarSandstoneRoofTurn180Block), typeof(AshlarSandstoneRoofTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRoofCornerBlock), typeof(AshlarSandstoneRoofCorner90Block), typeof(AshlarSandstoneRoofCorner180Block), typeof(AshlarSandstoneRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCornerFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofCorner270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneRoofPeakBlock), typeof(AshlarSandstoneRoofPeak90Block), typeof(AshlarSandstoneRoofPeak180Block), typeof(AshlarSandstoneRoofPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneRoofPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneRoofPeak270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderInnerPeakBlock), typeof(AshlarSandstoneUnderInnerPeak90Block), typeof(AshlarSandstoneUnderInnerPeak180Block), typeof(AshlarSandstoneUnderInnerPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderInnerPeakFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderInnerPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderInnerPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderInnerPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderInnerPeak270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneBraceTurnBlock), typeof(AshlarSandstoneBraceTurn90Block), typeof(AshlarSandstoneBraceTurn180Block), typeof(AshlarSandstoneBraceTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BraceTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneBraceTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneBraceTurn270Block : Block
    { }


    [RotatedVariants(typeof(AshlarSandstoneUnderBraceTurnBlock), typeof(AshlarSandstoneUnderBraceTurn90Block), typeof(AshlarSandstoneUnderBraceTurn180Block), typeof(AshlarSandstoneUnderBraceTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderBraceTurnFormType), typeof(AshlarSandstoneItem))]
    public partial class AshlarSandstoneUnderBraceTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class AshlarSandstoneUnderBraceTurn270Block : Block
    { }

}
