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
    [LocDisplayName("Wild Mix")]
    [Weight(600)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class WildMixItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A dressed salad that, with the added sweetness, its pretty tasty."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 11, Fat = 6, Protein = 8, Vitamins = 21};
        public override float Calories                          { get { return 800; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(AdvancedCookingSkill), 1)]    
    public partial class WildMixRecipe :
        RecipeFamily
    {
        public WildMixRecipe()
        {
            var product = new Recipe(
                "WildMix",
                Localizer.DoStr("Wild Mix"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(BasicSaladItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)), 
            new IngredientElement(typeof(HuckleberryExtractItem), 2, typeof(AdvancedCookingSkill), typeof(AdvancedCookingLavishResourcesTalent)),   
                },
                    new CraftingElement<WildMixItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Wild Mix"), typeof(WildMixRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(AdvancedCookingSkill), typeof(WildMixRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(WildMixRecipe), this.UILink(), 4, typeof(AdvancedCookingSkill), typeof(AdvancedCookingFocusedSpeedTalent), typeof(AdvancedCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Wild Mix"), typeof(WildMixRecipe));
            CraftingComponent.AddRecipe(typeof(KitchenObject), this);
        }
    }
}
