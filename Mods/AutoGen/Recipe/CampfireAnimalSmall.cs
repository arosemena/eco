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

    [RequiresSkill(typeof(CampfireCookingSkill), 0)] 
    public class CampfireAnimalSmallRecipe :
        RecipeFamily
    {
        public CampfireAnimalSmallRecipe()
        {
            this.Initialize(Localizer.DoStr("Campfire Animal Small"), typeof(CampfireAnimalSmallRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CampfireAnimalSmall",
                    Localizer.DoStr("Campfire Animal Small"),
                    new IngredientElement[]
                    {
               new IngredientElement("SmallCarcass", 1, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CharredMeatItem>(2), 
               new CraftingElement<TallowItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CampfireCookingSkill), typeof(CampfireAnimalSmallRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CampfireAnimalSmallRecipe), this.UILink(), 2, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));     
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}
