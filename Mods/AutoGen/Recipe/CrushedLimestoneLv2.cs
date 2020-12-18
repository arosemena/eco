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

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(MiningSkill), 1)] 
    public partial class CrushedLimestoneLv2Recipe :
        RecipeFamily
    {
        public CrushedLimestoneLv2Recipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CrushedLimestoneLv2",
                    Localizer.DoStr("Crushed Limestone Lv2"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(LimestoneItem), 20, true),  
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<CrushedLimestoneItem>(5),  
    
                    })
            };
            this.ExperienceOnCraft = 0.5f;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(MiningSkill), typeof(CrushedLimestoneLv2Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CrushedLimestoneLv2Recipe), this.UILink(), 1, typeof(MiningSkill));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Crushed Limestone Lv2"), typeof(CrushedLimestoneLv2Recipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(StampMillObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
