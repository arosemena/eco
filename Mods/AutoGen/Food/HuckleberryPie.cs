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
    [LocDisplayName("Huckleberry Pie")]
    [Weight(600)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class HuckleberryPieItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A fantastic combination of flaky crust and scrumptious berries."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 13, Fat = 10, Protein = 5, Vitamins = 16};
        public override float Calories                          { get { return 1300; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(BakingSkill), 3)]    
    public partial class HuckleberryPieRecipe :
        RecipeFamily
    {
        public HuckleberryPieRecipe()
        {
            var product = new Recipe(
                "HuckleberryPie",
                Localizer.DoStr("Huckleberry Pie"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(FlourItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), 
            new IngredientElement(typeof(HuckleberriesItem), 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
            new IngredientElement("Fat", 2, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                    new CraftingElement<HuckleberryPieItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Huckleberry Pie"), typeof(HuckleberryPieRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BakingSkill), typeof(HuckleberryPieRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(HuckleberryPieRecipe), this.UILink(), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Huckleberry Pie"), typeof(HuckleberryPieRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}
