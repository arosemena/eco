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

    public class CleanPacificSardineRecipe :
        RecipeFamily
    {
        public CleanPacificSardineRecipe()
        {
            this.Initialize(Localizer.DoStr("Clean Pacific Sardine"), typeof(CleanPacificSardineRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CleanPacificSardine",
                    Localizer.DoStr("Clean Pacific Sardine"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(PacificSardineItem), 2, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<RawFishItem>(1),  
                    })
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(30); 
            this.CraftMinutes = CreateCraftTimeValue(2);
            CraftingComponent.AddRecipe(typeof(FisheryObject), this);
        }
    }
}