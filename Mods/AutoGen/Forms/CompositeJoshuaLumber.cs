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
    [IsForm(typeof(WindowWallFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberWindowWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloorFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFloorBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(CladWallFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberCladWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WallFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FullWallFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFullWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WallTrimFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberWallTrimBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FlatRoofFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFlatRoofBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(CubeFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ColumnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(ThinColumnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberThinColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WindowFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(WindowGrillesFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberWindowGrillesBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(DoubleWindowFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberDoubleWindowBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FenceFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFenceBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(SideFenceFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberSideFenceBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderPeakSetFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(PeakSetFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakSetFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofPeakSetBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCubeFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeJoshuaLumberItem); } }
    }



    [RotatedVariants(typeof(CompositeJoshuaLumberRampABlock), typeof(CompositeJoshuaLumberRampA90Block), typeof(CompositeJoshuaLumberRampA180Block), typeof(CompositeJoshuaLumberRampA270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampAFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRampABlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampA90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampA180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampA270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRampBBlock), typeof(CompositeJoshuaLumberRampB90Block), typeof(CompositeJoshuaLumberRampB180Block), typeof(CompositeJoshuaLumberRampB270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampBFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRampBBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampB90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampB180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampB270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRampCBlock), typeof(CompositeJoshuaLumberRampC90Block), typeof(CompositeJoshuaLumberRampC180Block), typeof(CompositeJoshuaLumberRampC270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampCFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRampCBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampC90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampC180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampC270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRampDBlock), typeof(CompositeJoshuaLumberRampD90Block), typeof(CompositeJoshuaLumberRampD180Block), typeof(CompositeJoshuaLumberRampD270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RampDFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRampDBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampD90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampD180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRampD270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberLadderBlock), typeof(CompositeJoshuaLumberLadder90Block), typeof(CompositeJoshuaLumberLadder180Block), typeof(CompositeJoshuaLumberLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(LadderFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberLadderBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberLadder90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberLadder180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberLadder270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberStairsBlock), typeof(CompositeJoshuaLumberStairs90Block), typeof(CompositeJoshuaLumberStairs180Block), typeof(CompositeJoshuaLumberStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderStairsBlock), typeof(CompositeJoshuaLumberUnderStairs90Block), typeof(CompositeJoshuaLumberUnderStairs180Block), typeof(CompositeJoshuaLumberUnderStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderStairsFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberFloatStairsBlock), typeof(CompositeJoshuaLumberFloatStairs90Block), typeof(CompositeJoshuaLumberFloatStairs180Block), typeof(CompositeJoshuaLumberFloatStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFloatStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairs270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberBraceBlock), typeof(CompositeJoshuaLumberBrace90Block), typeof(CompositeJoshuaLumberBrace180Block), typeof(CompositeJoshuaLumberBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BraceFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderBraceBlock), typeof(CompositeJoshuaLumberUnderBrace90Block), typeof(CompositeJoshuaLumberUnderBrace180Block), typeof(CompositeJoshuaLumberUnderBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderBraceFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberSideBraceBlock), typeof(CompositeJoshuaLumberSideBrace90Block), typeof(CompositeJoshuaLumberSideBrace180Block), typeof(CompositeJoshuaLumberSideBrace270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(SideBraceFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberSideBraceBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberSideBrace90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberSideBrace180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberSideBrace270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberBasicSlopeSideBlock), typeof(CompositeJoshuaLumberBasicSlopeSide90Block), typeof(CompositeJoshuaLumberBasicSlopeSide180Block), typeof(CompositeJoshuaLumberBasicSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeSideFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberBasicSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberBasicSlopeCornerBlock), typeof(CompositeJoshuaLumberBasicSlopeCorner90Block), typeof(CompositeJoshuaLumberBasicSlopeCorner180Block), typeof(CompositeJoshuaLumberBasicSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeCornerFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberBasicSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberBasicSlopeTurnBlock), typeof(CompositeJoshuaLumberBasicSlopeTurn90Block), typeof(CompositeJoshuaLumberBasicSlopeTurn180Block), typeof(CompositeJoshuaLumberBasicSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopeTurnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberBasicSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberBasicSlopePointBlock), typeof(CompositeJoshuaLumberBasicSlopePoint90Block), typeof(CompositeJoshuaLumberBasicSlopePoint180Block), typeof(CompositeJoshuaLumberBasicSlopePoint270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(BasicSlopePointFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberBasicSlopePointBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopePoint90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopePoint180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberBasicSlopePoint270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberFloatStairsCornerBlock), typeof(CompositeJoshuaLumberFloatStairsCorner90Block), typeof(CompositeJoshuaLumberFloatStairsCorner180Block), typeof(CompositeJoshuaLumberFloatStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsCornerFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFloatStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberFloatStairsTurnBlock), typeof(CompositeJoshuaLumberFloatStairsTurn90Block), typeof(CompositeJoshuaLumberFloatStairsTurn180Block), typeof(CompositeJoshuaLumberFloatStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(FloatStairsTurnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberFloatStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberFloatStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberStairsCornerBlock), typeof(CompositeJoshuaLumberStairsCorner90Block), typeof(CompositeJoshuaLumberStairsCorner180Block), typeof(CompositeJoshuaLumberStairsCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsCornerFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberStairsCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberStairsTurnBlock), typeof(CompositeJoshuaLumberStairsTurn90Block), typeof(CompositeJoshuaLumberStairsTurn180Block), typeof(CompositeJoshuaLumberStairsTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(StairsTurnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberStairsTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberStairsTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderSlopeSideBlock), typeof(CompositeJoshuaLumberUnderSlopeSide90Block), typeof(CompositeJoshuaLumberUnderSlopeSide180Block), typeof(CompositeJoshuaLumberUnderSlopeSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeSideFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderSlopeSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderSlopeCornerBlock), typeof(CompositeJoshuaLumberUnderSlopeCorner90Block), typeof(CompositeJoshuaLumberUnderSlopeCorner180Block), typeof(CompositeJoshuaLumberUnderSlopeCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeCornerFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderSlopeCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderSlopeTurnBlock), typeof(CompositeJoshuaLumberUnderSlopeTurn90Block), typeof(CompositeJoshuaLumberUnderSlopeTurn180Block), typeof(CompositeJoshuaLumberUnderSlopeTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopeTurnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderSlopeTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopeTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderSlopePeakBlock), typeof(CompositeJoshuaLumberUnderSlopePeak90Block), typeof(CompositeJoshuaLumberUnderSlopePeak180Block), typeof(CompositeJoshuaLumberUnderSlopePeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderSlopePeakFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderSlopePeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopePeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopePeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderSlopePeak270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRoofSideBlock), typeof(CompositeJoshuaLumberRoofSide90Block), typeof(CompositeJoshuaLumberRoofSide180Block), typeof(CompositeJoshuaLumberRoofSide270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofSideFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofSideBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofSide90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofSide180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofSide270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRoofTurnBlock), typeof(CompositeJoshuaLumberRoofTurn90Block), typeof(CompositeJoshuaLumberRoofTurn180Block), typeof(CompositeJoshuaLumberRoofTurn270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofTurnFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofTurnBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofTurn90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofTurn180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofTurn270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRoofCornerBlock), typeof(CompositeJoshuaLumberRoofCorner90Block), typeof(CompositeJoshuaLumberRoofCorner180Block), typeof(CompositeJoshuaLumberRoofCorner270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofCornerFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofCornerBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofCorner90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofCorner180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofCorner270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberRoofPeakBlock), typeof(CompositeJoshuaLumberRoofPeak90Block), typeof(CompositeJoshuaLumberRoofPeak180Block), typeof(CompositeJoshuaLumberRoofPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(RoofPeakFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberRoofPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberRoofPeak270Block : Block
    { }


    [RotatedVariants(typeof(CompositeJoshuaLumberUnderInnerPeakBlock), typeof(CompositeJoshuaLumberUnderInnerPeak90Block), typeof(CompositeJoshuaLumberUnderInnerPeak180Block), typeof(CompositeJoshuaLumberUnderInnerPeak270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    [IsForm(typeof(UnderInnerPeakFormType), typeof(CompositeJoshuaLumberItem))]
    public partial class CompositeJoshuaLumberUnderInnerPeakBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderInnerPeak90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderInnerPeak180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(4)] 
    public partial class CompositeJoshuaLumberUnderInnerPeak270Block : Block
    { }

}