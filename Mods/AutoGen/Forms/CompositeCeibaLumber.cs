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
    [IsForm(typeof(WindowWallFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberWindowWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloorFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFloorBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(CladWallFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberCladWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WallFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FullWallFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFullWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WallTrimFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberWallTrimBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FlatRoofFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFlatRoofBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(CubeFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ColumnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ThinColumnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberThinColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WindowFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WindowGrillesFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberWindowGrillesBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(DoubleWindowFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberDoubleWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FenceFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFenceBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(SideFenceFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberSideFenceBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderPeakSetFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(PeakSetFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakSetFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCubeFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeCeibaLumberItem); } }
    }



    [RotatedVariants(typeof(CompositeCeibaLumberRampABlock), typeof(CompositeCeibaLumberRampA90Block), typeof(CompositeCeibaLumberRampA180Block), typeof(CompositeCeibaLumberRampA270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampAFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRampABlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampA90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampA180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampA270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRampBBlock), typeof(CompositeCeibaLumberRampB90Block), typeof(CompositeCeibaLumberRampB180Block), typeof(CompositeCeibaLumberRampB270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampBFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRampBBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampB90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampB180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampB270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRampCBlock), typeof(CompositeCeibaLumberRampC90Block), typeof(CompositeCeibaLumberRampC180Block), typeof(CompositeCeibaLumberRampC270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampCFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRampCBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampC90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampC180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampC270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRampDBlock), typeof(CompositeCeibaLumberRampD90Block), typeof(CompositeCeibaLumberRampD180Block), typeof(CompositeCeibaLumberRampD270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampDFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRampDBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampD90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampD180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRampD270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberLadderBlock), typeof(CompositeCeibaLumberLadder90Block), typeof(CompositeCeibaLumberLadder180Block), typeof(CompositeCeibaLumberLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(LadderFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberLadderBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberLadder90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberLadder180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberLadder270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberStairsBlock), typeof(CompositeCeibaLumberStairs90Block), typeof(CompositeCeibaLumberStairs180Block), typeof(CompositeCeibaLumberStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderStairsBlock), typeof(CompositeCeibaLumberUnderStairs90Block), typeof(CompositeCeibaLumberUnderStairs180Block), typeof(CompositeCeibaLumberUnderStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderStairsFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberFloatStairsBlock), typeof(CompositeCeibaLumberFloatStairs90Block), typeof(CompositeCeibaLumberFloatStairs180Block), typeof(CompositeCeibaLumberFloatStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFloatStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberBraceBlock), typeof(CompositeCeibaLumberBrace90Block), typeof(CompositeCeibaLumberBrace180Block), typeof(CompositeCeibaLumberBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BraceFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderBraceBlock), typeof(CompositeCeibaLumberUnderBrace90Block), typeof(CompositeCeibaLumberUnderBrace180Block), typeof(CompositeCeibaLumberUnderBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderBraceFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberSideBraceBlock), typeof(CompositeCeibaLumberSideBrace90Block), typeof(CompositeCeibaLumberSideBrace180Block), typeof(CompositeCeibaLumberSideBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(SideBraceFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberSideBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberSideBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberSideBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberSideBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberBasicSlopeSideBlock), typeof(CompositeCeibaLumberBasicSlopeSide90Block), typeof(CompositeCeibaLumberBasicSlopeSide180Block), typeof(CompositeCeibaLumberBasicSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeSideFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberBasicSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberBasicSlopeCornerBlock), typeof(CompositeCeibaLumberBasicSlopeCorner90Block), typeof(CompositeCeibaLumberBasicSlopeCorner180Block), typeof(CompositeCeibaLumberBasicSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeCornerFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberBasicSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberBasicSlopeTurnBlock), typeof(CompositeCeibaLumberBasicSlopeTurn90Block), typeof(CompositeCeibaLumberBasicSlopeTurn180Block), typeof(CompositeCeibaLumberBasicSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeTurnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberBasicSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberBasicSlopePointBlock), typeof(CompositeCeibaLumberBasicSlopePoint90Block), typeof(CompositeCeibaLumberBasicSlopePoint180Block), typeof(CompositeCeibaLumberBasicSlopePoint270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopePointFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberBasicSlopePointBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopePoint90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopePoint180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberBasicSlopePoint270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberFloatStairsCornerBlock), typeof(CompositeCeibaLumberFloatStairsCorner90Block), typeof(CompositeCeibaLumberFloatStairsCorner180Block), typeof(CompositeCeibaLumberFloatStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsCornerFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFloatStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberFloatStairsTurnBlock), typeof(CompositeCeibaLumberFloatStairsTurn90Block), typeof(CompositeCeibaLumberFloatStairsTurn180Block), typeof(CompositeCeibaLumberFloatStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsTurnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberFloatStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberFloatStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberStairsCornerBlock), typeof(CompositeCeibaLumberStairsCorner90Block), typeof(CompositeCeibaLumberStairsCorner180Block), typeof(CompositeCeibaLumberStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsCornerFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberStairsTurnBlock), typeof(CompositeCeibaLumberStairsTurn90Block), typeof(CompositeCeibaLumberStairsTurn180Block), typeof(CompositeCeibaLumberStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsTurnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderSlopeSideBlock), typeof(CompositeCeibaLumberUnderSlopeSide90Block), typeof(CompositeCeibaLumberUnderSlopeSide180Block), typeof(CompositeCeibaLumberUnderSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeSideFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderSlopeCornerBlock), typeof(CompositeCeibaLumberUnderSlopeCorner90Block), typeof(CompositeCeibaLumberUnderSlopeCorner180Block), typeof(CompositeCeibaLumberUnderSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeCornerFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderSlopeTurnBlock), typeof(CompositeCeibaLumberUnderSlopeTurn90Block), typeof(CompositeCeibaLumberUnderSlopeTurn180Block), typeof(CompositeCeibaLumberUnderSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeTurnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderSlopePeakBlock), typeof(CompositeCeibaLumberUnderSlopePeak90Block), typeof(CompositeCeibaLumberUnderSlopePeak180Block), typeof(CompositeCeibaLumberUnderSlopePeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopePeakFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderSlopePeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopePeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopePeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderSlopePeak270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRoofSideBlock), typeof(CompositeCeibaLumberRoofSide90Block), typeof(CompositeCeibaLumberRoofSide180Block), typeof(CompositeCeibaLumberRoofSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofSideFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRoofTurnBlock), typeof(CompositeCeibaLumberRoofTurn90Block), typeof(CompositeCeibaLumberRoofTurn180Block), typeof(CompositeCeibaLumberRoofTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofTurnFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRoofCornerBlock), typeof(CompositeCeibaLumberRoofCorner90Block), typeof(CompositeCeibaLumberRoofCorner180Block), typeof(CompositeCeibaLumberRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCornerFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberRoofPeakBlock), typeof(CompositeCeibaLumberRoofPeak90Block), typeof(CompositeCeibaLumberRoofPeak180Block), typeof(CompositeCeibaLumberRoofPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberRoofPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberRoofPeak270Block : Block
    { }


    [RotatedVariants(typeof(CompositeCeibaLumberUnderInnerPeakBlock), typeof(CompositeCeibaLumberUnderInnerPeak90Block), typeof(CompositeCeibaLumberUnderInnerPeak180Block), typeof(CompositeCeibaLumberUnderInnerPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderInnerPeakFormType), typeof(CompositeCeibaLumberItem))]
    public partial class CompositeCeibaLumberUnderInnerPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderInnerPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderInnerPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeCeibaLumberUnderInnerPeak270Block : Block
    { }

}