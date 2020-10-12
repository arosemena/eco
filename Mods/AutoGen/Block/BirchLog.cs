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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;


    [Serialized]
    [Solid, Wall, Constructed]
    public partial class BirchLogBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(BirchLogItem); } }
    }

    [Serialized]
    [LocDisplayName("Birch Log")]
    [MaxStackSize(20 * 2)]
    [Weight(10000)]
    [Fuel(4000)][Tag("Fuel")]
    [Ecopedia("Natural Resources", "Logs", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Wood", 1)]
    [Tag("Hardwood", 1)]
    [Tag("Burnable Fuel", 1)]
    public partial class BirchLogItem :
    BlockItem<BirchLogBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Birch log is a type of hardwood, notable for its white and papery bark."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(BirchLogStacked1Block),
        typeof(BirchLogStacked2Block),
        typeof(BirchLogStacked3Block),
            typeof(BirchLogStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class BirchLogStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class BirchLogStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class BirchLogStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class BirchLogStacked4Block : PickupableBlock { } //Only a wall if it's all 4 BirchLog
}
