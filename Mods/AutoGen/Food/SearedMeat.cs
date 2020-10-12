﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.EcopediaRoot;

    [Serialized]
    [LocDisplayName("Seared Meat")]
    [Weight(500)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class SearedMeatItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Seared Meat"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A cut of perfectly seared steak."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 4, Fat = 17, Protein = 19, Vitamins = 7};
        public override float Calories                          { get { return 600; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(AdvancedCookingSkill), 1)]    
    public partial class SearedMeatRecipe :
        RecipeFamily
    {
        public SearedMeatRecipe()
        {
            var product = new Recipe(
                "SearedMeat",
                Localizer.DoStr("Seared Meat"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(PrimeCutItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)), 
            new IngredientElement(typeof(InfusedOilItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),   
                },
                    new CraftingElement<SearedMeatItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Seared Meat"), typeof(SearedMeatRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(AdvancedCookingSkill), typeof(SearedMeatRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SearedMeatRecipe), this.UILink(), 3, typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Seared Meat"), typeof(SearedMeatRecipe));
            CraftingComponent.AddRecipe(typeof(StoveObject), this);
        }
    }
}