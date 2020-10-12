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

    [RequiresSkill(typeof(MiningSkill), 2)] 
    public class CrushedGoldLv3Recipe :
        RecipeFamily
    {
        public CrushedGoldLv3Recipe()
        {
            this.Initialize(Localizer.DoStr("Crushed Gold Lv3"), typeof(CrushedGoldLv3Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CrushedGoldLv3",
                    Localizer.DoStr("Crushed Gold Lv3"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(GoldOreItem), 20, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CrushedGoldOreItem>(5),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(MiningSkill), typeof(CrushedGoldLv3Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CrushedGoldLv3Recipe), this.UILink(), 0.5f, typeof(MiningSkill));     
            CraftingComponent.AddRecipe(typeof(JawCrusherObject), this);
        }
    }
}
