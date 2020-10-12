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
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    public partial class MortaredShaleBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(MortaredShaleItem); } }
    }

    [Serialized]
    [LocDisplayName("Mortared Shale")]
    [MaxStackSize(30)]
    [Category("Hidden")]
    public partial class MortaredShaleItem :
    BlockItem<MortaredShaleBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Used to create tough but rudimentary buildings."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(MortaredShaleStacked1Block),
        typeof(MortaredShaleStacked2Block),
            typeof(MortaredShaleStacked3Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class MortaredShaleStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class MortaredShaleStacked2Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class MortaredShaleStacked3Block : PickupableBlock { } //Only a wall if it's all 4 MortaredShale
}
