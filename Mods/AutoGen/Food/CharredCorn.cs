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
    [LocDisplayName("Charred Corn")]
    [Weight(100)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("CharredVegetable", 1)]
    public partial class CharredCornItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Charred Corn"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("This piece of corn needs a good slathering of butter to curb that burnt taste."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 7, Fat = 0, Protein = 1, Vitamins = 4};
        public override float Calories                          { get { return 350; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]    
    public partial class CharredCornRecipe :
        RecipeFamily
    {
        public CharredCornRecipe()
        {
            var product = new Recipe(
                "CharredCorn",
                Localizer.DoStr("Charred Corn"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(CornItem), 1, true),  
                },
                    new CraftingElement<CharredCornItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Charred Corn"), typeof(CharredCornRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill), typeof(CharredCornRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredCornRecipe), this.UILink(), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Charred Corn"), typeof(CharredCornRecipe));
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}
