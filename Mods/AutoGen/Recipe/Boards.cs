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
    public partial class BoardsRecipe :
        RecipeFamily
    {
        public BoardsRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Boards",
                    Localizer.DoStr("Boards"),
                    new IngredientElement[]
                    {
               new IngredientElement("HewnLog", 1),   
                    },
                    new CraftingElement[]
                    {
               new CraftingElement<BoardItem>(1),  
                    })
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(60); 
            this.CraftMinutes = CreateCraftTimeValue(0.2f);
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Boards"), typeof(BoardsRecipe));
            this.ModsPostInitialize();
            CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }
}
