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
    [LocDisplayName("Charred Beet")]
    [Weight(100)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("CharredVegetable", 1)]
    public partial class CharredBeetItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Perhaps not the best raw vegetable to char, this beet seems to have held up well enough."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 3, Fat = 3, Protein = 0, Vitamins = 6};
        public override float Calories                          { get { return 350; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]    
    public partial class CharredBeetRecipe :
        RecipeFamily
    {
        public CharredBeetRecipe()
        {
            var product = new Recipe(
                "CharredBeet",
                Localizer.DoStr("Charred Beet"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(BeetItem), 1, true),  
                },
                    new CraftingElement<CharredBeetItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Charred Beet"), typeof(CharredBeetRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill), typeof(CharredBeetRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredBeetRecipe), this.UILink(), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Charred Beet"), typeof(CharredBeetRecipe));
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}
