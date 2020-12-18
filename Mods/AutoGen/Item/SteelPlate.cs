﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(IndustrySkill), 1)]      
    public partial class SteelPlateRecipe :
        RecipeFamily
    {
        public SteelPlateRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelPlate",
                    Localizer.DoStr("Steel Plate"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 3, typeof(IndustrySkill), typeof(IndustryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelPlateItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(IndustrySkill), typeof(SteelPlateRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelPlateRecipe), this.UILink(), 1.5f, typeof(IndustrySkill), typeof(IndustryFocusedSpeedTalent), typeof(IndustryParallelSpeedTalent));     
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Steel Plate"), typeof(SteelPlateRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(typeof(ElectricStampingPressObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [LocDisplayName("Steel Plate")]
    [Weight(500)]      
    [Tag("Currency")][Currency]              
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SteelPlateItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A sturdy steel plate for use in various crafting recipes."); } }
    }
}
