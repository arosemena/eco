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
    [Solid, Wall, Cliff, Minable(1)]
    public partial class SandstoneBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SandstoneItem); } }
    }

    [Serialized]
    [LocDisplayName("Sandstone")]
    [MaxStackSize(40)]
    [Weight(15000)]
    [Ecopedia("Natural Resources", "Stone", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Rock", 1)]
    public partial class SandstoneItem :
    BlockItem<SandstoneBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Sandstone"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("A rock of varying hardness, useful for construction and as a host for iron ore. Sandstone is a sedimentary rock that forms when sand is buried deeply enough to lithify. Sometimes the shapes of dunes and ripples from an ancient desert or beach are preserved!"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(SandstoneStacked1Block),
        typeof(SandstoneStacked2Block),
        typeof(SandstoneStacked3Block),
            typeof(SandstoneStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class SandstoneStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class SandstoneStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class SandstoneStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class SandstoneStacked4Block : PickupableBlock { } //Only a wall if it's all 4 Sandstone
}
