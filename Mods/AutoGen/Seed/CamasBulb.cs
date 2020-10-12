﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System.Collections.Generic;
    using Eco.Gameplay.Blocks;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.SearchAndSelect;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Players;
    using System.ComponentModel;

    [Serialized]
    [LocDisplayName("Camas Bulb")]
    [Yield(typeof(CamasBulbItem), typeof(GatheringSkill), new float[] { 1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f })]  
    [Crop]  
    [Weight(10)]  
    [StartsDiscovered]
    [Tag("Vegetable", 1)]
    [Tag("Root", 1)]
    [Tag("Raw Food", 1)]
    [Tag("Crop", 1)]
    [Tag("Crop Seed", 1)]                                 
    public partial class CamasBulbItem : SeedItem
    {
        static CamasBulbItem() { }
        
        private static Nutrients nutrition = new Nutrients() { Carbs = 1, Fat = 5, Protein = 2, Vitamins = 0 };

        public override LocString DisplayDescription { get { return Localizer.DoStr("Plant to grow a camas plant."); } }
        public override LocString SpeciesName        { get { return Localizer.DoStr("Camas"); } }

        public override float Calories { get { return 150; } }
        public override Nutrients Nutrition { get { return nutrition; } }
    }


    [Serialized]
    [LocDisplayName("Camas Bulb Pack")]
    [Category("Hidden")]
    [Weight(10)]  
    public partial class CamasBulbPackItem : SeedPackItem
    {
        static CamasBulbPackItem() { }

        public override LocString DisplayDescription { get { return Localizer.DoStr("Plant to grow a camas plant."); } }
        public override LocString SpeciesName        { get { return Localizer.DoStr("Camas"); } }
    }

}