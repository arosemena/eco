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
    public class CrushedSandstoneLv3Recipe :
        RecipeFamily
    {
        public CrushedSandstoneLv3Recipe()
        {
            this.Initialize(Localizer.DoStr("Crushed Sandstone Lv3"), typeof(CrushedSandstoneLv3Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CrushedSandstoneLv3",
                    Localizer.DoStr("Crushed Sandstone Lv3"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(SandstoneItem), 20, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CrushedSandstoneItem>(5),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(MiningSkill), typeof(CrushedSandstoneLv3Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CrushedSandstoneLv3Recipe), this.UILink(), 0.5f, typeof(MiningSkill));     
            CraftingComponent.AddRecipe(typeof(JawCrusherObject), this);
        }
    }
}
