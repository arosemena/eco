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
    [BlockTier(1)] 
    [IsForm(typeof(FloorFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogFloorBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(WallFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogWallBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(CubeFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(RoofFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogRoofBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(ColumnFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogColumnBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }


    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(WindowGrillesFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogWindowGrillesBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodHewnLogItem); } }
    }



    [RotatedVariants(typeof(SoftwoodHewnLogStairsBlock), typeof(SoftwoodHewnLogStairs90Block), typeof(SoftwoodHewnLogStairs180Block), typeof(SoftwoodHewnLogStairs270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(StairsFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogStairsBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogStairs90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogStairs180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogStairs270Block : Block
    { }


    [RotatedVariants(typeof(SoftwoodHewnLogLadderBlock), typeof(SoftwoodHewnLogLadder90Block), typeof(SoftwoodHewnLogLadder180Block), typeof(SoftwoodHewnLogLadder270Block))]
    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    [IsForm(typeof(LadderFormType), typeof(SoftwoodHewnLogItem))]
    public partial class SoftwoodHewnLogLadderBlock : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogLadder90Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogLadder180Block : Block
    { }

    [Serialized]
    [Wall, Constructed, Solid, BuildRoomMaterialOption] 
    [BlockTier(1)] 
    public partial class SoftwoodHewnLogLadder270Block : Block
    { }

}