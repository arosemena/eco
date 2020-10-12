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
    public partial class RebarRecipe :
        RecipeFamily
    {
        public RebarRecipe()
        {
            this.Initialize(Localizer.DoStr("Rebar"), typeof(RebarRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Rebar",
                    Localizer.DoStr("Rebar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<RebarItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(80, typeof(AdvancedSmeltingSkill), typeof(RebarRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RebarRecipe), this.UILink(), 0.2f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Rebar"), typeof(RebarRecipe));

            CraftingComponent.AddRecipe(typeof(BlastFurnaceObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Rebar")]
    [Weight(3000)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class RebarItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Ribbed steel bars for reinforcing stuctures."); } }
    }
}
