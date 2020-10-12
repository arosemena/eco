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
    public class MushroomMedleyRecipe :
        RecipeFamily
    {
        public MushroomMedleyRecipe()
        {
            this.Initialize(Localizer.DoStr("Mushroom Medley"), typeof(MushroomMedleyRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "MushroomMedley",
                    Localizer.DoStr("Mushroom Medley"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(CriminiMushroomsItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
               new IngredientElement(typeof(CookeinaMushroomsItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
               new IngredientElement(typeof(BoleteMushroomsItem), 4, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<VegetableMedleyItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CookingSkill), typeof(MushroomMedleyRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(MushroomMedleyRecipe), this.UILink(), 0.8f, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));     
            CraftingComponent.AddRecipe(typeof(CastIronStoveObject), this);
        }
    }
}
