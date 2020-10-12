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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]      
    public partial class SteelSawBladeRecipe :
        RecipeFamily
    {
        public SteelSawBladeRecipe()
        {
            this.Initialize(Localizer.DoStr("Steel Saw Blade"), typeof(SteelSawBladeRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelSawBlade",
                    Localizer.DoStr("Steel Saw Blade"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 10, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelSawBladeItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(300, typeof(AdvancedSmeltingSkill), typeof(SteelSawBladeRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelSawBladeRecipe), this.UILink(), 1.2f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Steel Saw Blade"), typeof(SteelSawBladeRecipe));

            CraftingComponent.AddRecipe(typeof(AnvilObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Steel Saw Blade")]
    [Weight(100)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SteelSawBladeItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A disc shaped steel saw that can be attached to rotary machines to shape wood and masonry products."); } }
    }
}
