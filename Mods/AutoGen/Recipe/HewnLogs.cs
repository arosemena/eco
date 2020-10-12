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

    [RequiresSkill(typeof(LoggingSkill), 1)] 
    public class HewnLogsRecipe :
        RecipeFamily
    {
        public HewnLogsRecipe()
        {
            this.Initialize(Localizer.DoStr("Hewn Logs"), typeof(HewnLogsRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "HewnLogs",
                    Localizer.DoStr("Hewn Logs"),
                    new IngredientElement[]
                    {
               new IngredientElement("Wood", 2, typeof(LoggingSkill)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<HewnLogItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(LoggingSkill), typeof(HewnLogsRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(HewnLogsRecipe), this.UILink(), 0.15f, typeof(LoggingSkill));     
            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }
}