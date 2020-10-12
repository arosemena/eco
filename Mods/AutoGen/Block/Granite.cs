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
    [Solid, Wall, Cliff, Minable(2)]
    public partial class GraniteBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GraniteItem); } }
    }

    [Serialized]
    [LocDisplayName("Granite")]
    [MaxStackSize(40)]
    [Weight(15000)]
    [ResourcePile]
    [Ecopedia("Natural Resources", "Stone", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Rock", 1)]
    public partial class GraniteItem :
    BlockItem<GraniteBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Granite"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("A hard rock useful for construction, and host to various ores. Granite forms from cooling magma deep underground. It is the most common continental rock type!"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(GraniteStacked1Block),
        typeof(GraniteStacked2Block),
        typeof(GraniteStacked3Block),
            typeof(GraniteStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class GraniteStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class GraniteStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class GraniteStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class GraniteStacked4Block : PickupableBlock { } //Only a wall if it's all 4 Granite
}
