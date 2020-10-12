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

    [RequiresSkill(typeof(CookingSkill), 1)] 
    public class ExoticSaladRecipe :
        RecipeFamily
    {
        public ExoticSaladRecipe()
        {
            this.Initialize(Localizer.DoStr("Exotic Salad"), typeof(ExoticSaladRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ExoticSalad",
                    Localizer.DoStr("Exotic Salad"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(PricklyPearFruitItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
               new IngredientElement(typeof(CriminiMushroomsItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
               new IngredientElement(typeof(RiceItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<BasicSaladItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CookingSkill), typeof(ExoticSaladRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ExoticSaladRecipe), this.UILink(), 4, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));     
            CraftingComponent.AddRecipe(typeof(CastIronStoveObject), this);
        }
    }
}
