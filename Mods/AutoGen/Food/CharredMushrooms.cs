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
    [LocDisplayName("Charred Mushrooms")]
    [Weight(100)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("CharredVegetable", 1)]
    public partial class CharredMushroomsItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A collection of charred mushrooms. Cooking mushrooms properly can remove some of the toxins."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 3, Fat = 2, Protein = 6, Vitamins = 1};
        public override float Calories                          { get { return 350; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]    
    public partial class CharredMushroomsRecipe :
        RecipeFamily
    {
        public CharredMushroomsRecipe()
        {
            var product = new Recipe(
                "CharredMushrooms",
                Localizer.DoStr("Charred Mushrooms"),
                new IngredientElement[]
                {
            new IngredientElement("Fungus", 1, true),   
                },
                    new CraftingElement<CharredMushroomsItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Charred Mushrooms"), typeof(CharredMushroomsRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill), typeof(CharredMushroomsRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredMushroomsRecipe), this.UILink(), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Charred Mushrooms"), typeof(CharredMushroomsRecipe));
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}