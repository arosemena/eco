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

    [RequiresSkill(typeof(MasonrySkill), 1)] 
    public class BakedMortarRecipe :
        RecipeFamily
    {
        public BakedMortarRecipe()
        {
            this.Initialize(Localizer.DoStr("Baked Mortar"), typeof(BakedMortarRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "BakedMortar",
                    Localizer.DoStr("Baked Mortar"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(WoodPulpItem), 5, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<MortarItem>(1),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(MasonrySkill), typeof(BakedMortarRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BakedMortarRecipe), this.UILink(), 0.1f, typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));     
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}