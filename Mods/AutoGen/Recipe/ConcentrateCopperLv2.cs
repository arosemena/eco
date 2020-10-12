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

    [RequiresSkill(typeof(MiningSkill), 4)] 
    public class ConcentrateCopperLv2Recipe :
        RecipeFamily
    {
        public ConcentrateCopperLv2Recipe()
        {
            this.Initialize(Localizer.DoStr("Concentrate Copper Lv2"), typeof(ConcentrateCopperLv2Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ConcentrateCopperLv2",
                    Localizer.DoStr("Concentrate Copper Lv2"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(CrushedCopperOreItem), 7, typeof(MiningSkill)),    
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CopperConcentrateItem>(2),  
               new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 2),     
                    })
            };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(MiningSkill), typeof(ConcentrateCopperLv2Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ConcentrateCopperLv2Recipe), this.UILink(), 0.8f, typeof(MiningSkill));     
            CraftingComponent.AddRecipe(typeof(FrothFloatationCellObject), this);
        }
    }
}