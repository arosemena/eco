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
    [LocDisplayName("Agouti Carcass")]
    [Weight(2000)]      
    [Ecopedia("Natural Resources", "Animal", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("TinyFurCarcass", 1)]
    [Tag("Carcass", 1)]
    [Tag("TinyCarcass", 1)]
    [Tag("Animal", 1)]                                 
    public partial class AgoutiCarcassItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A dead agouti."); } }
    }
}
