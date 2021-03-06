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
    [LocDisplayName("Raw Roast")]
    [Weight(500)]
    [Ecopedia("Food", "Meat", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class RawRoastItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A trussed roast tied and ready to be cooked."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 0, Fat = 5, Protein = 6, Vitamins = 0};
        public override float Calories                          { get { return 600; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(ButcherySkill), 1)]    
    public partial class RawRoastRecipe :
        RecipeFamily
    {
        public RawRoastRecipe()
        {
            var product = new Recipe(
                "RawRoast",
                Localizer.DoStr("Raw Roast"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(RawMeatItem), 2, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),   
                },
                    new CraftingElement<RawRoastItem>(1),  
                    new CraftingElement<ScrapMeatItem>(3f)  
                
            );
            this.Initialize(Localizer.DoStr("Raw Roast"), typeof(RawRoastRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(ButcherySkill), typeof(RawRoastRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RawRoastRecipe), this.UILink(), 0.8f, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Raw Roast"), typeof(RawRoastRecipe));
            CraftingComponent.AddRecipe(typeof(ButcheryTableObject), this);
        }
    }
}
