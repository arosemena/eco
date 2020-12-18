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

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>

    [Serialized]
    [Solid, Wall, Constructed]
    public partial class RedwoodLogBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(RedwoodLogItem); } }
    }

    [Serialized]
    [LocDisplayName("Redwood Log")]
    [MaxStackSize(60)]
    [Weight(10000)]
    [Fuel(4000)][Tag("Fuel")]
    [Ecopedia("Natural Resources", "Logs", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency][Tag("Currency")]
    [Tag("Wood", 1)]
    [Tag("Softwood", 1)]
    [Tag("Burnable Fuel", 1)]
    public partial class RedwoodLogItem :
    BlockItem<RedwoodLogBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Redwood log is a type of softwood that can be easily identified by its distinct red bark."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(RedwoodLogStacked1Block),
        typeof(RedwoodLogStacked2Block),
        typeof(RedwoodLogStacked3Block),
            typeof(RedwoodLogStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class RedwoodLogStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class RedwoodLogStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class RedwoodLogStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class RedwoodLogStacked4Block : PickupableBlock { } //Only a wall if it's all 4 RedwoodLog
}
