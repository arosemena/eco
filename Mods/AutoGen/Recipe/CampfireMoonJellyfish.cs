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
    public class CampfireMoonJellyfishRecipe :
        RecipeFamily
    {
        public CampfireMoonJellyfishRecipe()
        {
            this.Initialize(Localizer.DoStr("Campfire Moon Jellyfish"), typeof(CampfireMoonJellyfishRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CampfireMoonJellyfish",
                    Localizer.DoStr("Campfire Moon Jellyfish"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(MoonJellyfishItem), 1, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CharredFishItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CampfireCookingSkill), typeof(CampfireMoonJellyfishRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CampfireMoonJellyfishRecipe), this.UILink(), 0.4f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));     
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}