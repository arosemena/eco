﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;

    public class CleanSalmonRecipe :
        RecipeFamily
    {
        public CleanSalmonRecipe()
        {
            this.Initialize(Localizer.DoStr("Clean Salmon"), typeof(CleanSalmonRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CleanSalmon",
                    Localizer.DoStr("Clean Salmon"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(SalmonItem), 1, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<RawFishItem>(4),  
                    })
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(30); 
            this.CraftMinutes = CreateCraftTimeValue(1);
            CraftingComponent.AddRecipe(typeof(FisheryObject), this);
        }
    }
}