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
    [LocDisplayName("Fruit Muffin")]
    [Weight(200)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class FruitMuffinItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A soft, slightly sweet bread studded with juicy fruits."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 5, Fat = 4, Protein = 5, Vitamins = 16};
        public override float Calories                          { get { return 800; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(BakingSkill), 1)]    
    public partial class FruitMuffinRecipe :
        RecipeFamily
    {
        public FruitMuffinRecipe()
        {
            var product = new Recipe(
                "FruitMuffin",
                Localizer.DoStr("Fruit Muffin"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(FlourItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
            new IngredientElement("Fruit", 8, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                    new CraftingElement<FruitMuffinItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Fruit Muffin"), typeof(FruitMuffinRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BakingSkill), typeof(FruitMuffinRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(FruitMuffinRecipe), this.UILink(), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Fruit Muffin"), typeof(FruitMuffinRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}