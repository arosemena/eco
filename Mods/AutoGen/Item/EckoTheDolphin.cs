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
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;


    [Serialized]
    [LocDisplayName("Ecko The Dolphin")]
    [Weight(0)]      
    [Category("Hidden")]    
    public partial class EckoTheDolphinItem :
    ToolItem                        
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Ecko, the dolphin god of Eco bugs. Handle with care and lightly sprinkle with water every so often to keep moist."); } }
    }
}
