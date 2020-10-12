﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Shared.Math;

    public partial class WoodenHoeRecipe :
        RecipeFamily
    {
        public WoodenHoeRecipe()
        {
            this.Initialize(Localizer.DoStr("Wooden Hoe"), typeof(WoodenHoeRecipe));            
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "WoodenHoe",
                    new IngredientElement[]
                    {
               new IngredientElement("Wood", 10),   
                    },
                new CraftingElement<WoodenHoeItem>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(10); 
            this.CraftMinutes = CreateCraftTimeValue(0.5f);
            this.Initialize(Localizer.DoStr("Wooden Hoe"), typeof(WoodenHoeRecipe));
            CraftingComponent.AddRecipe(typeof(ToolBenchObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Wooden Hoe")]
    [Tier(1)] 
    [Weight(1000)]
    [Category("Tool")]
    [Tag("Tool", 1)]
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                    
    public partial class WoodenHoeItem : HoeItem
    {
        // Static values
        private static IDynamicValue caloriesBurn = CreateCalorieValue(20, typeof(FarmingSkill), typeof(WoodenHoeItem), new WoodenHoeItem().UILink());
        private static IDynamicValue exp = new ConstantValue(0.1f);
        private static IDynamicValue tier = new ConstantValue(1);
        private static IDynamicValue skilledRepairCost = new ConstantValue(5);  
        

        // Tool overrides

        public override IDynamicValue CaloriesBurn      => caloriesBurn;
        public override Type ExperienceSkill            => typeof(FarmingSkill);
        public override IDynamicValue ExperienceRate    => exp;
        public override IDynamicValue Tier              => tier;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override float DurabilityRate            => DurabilityMax / 75f;
        public override Item RepairItem                 => Item.Get<Item>();
        public override Tag RepairTag                   => TagManager.Tag("Wood");
        public override int FullRepairAmount            => 5;
    }
}
