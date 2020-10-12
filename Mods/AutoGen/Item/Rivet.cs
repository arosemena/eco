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
    public partial class RivetRecipe :
        RecipeFamily
    {
        public RivetRecipe()
        {
            this.Initialize(Localizer.DoStr("Rivet"), typeof(RivetRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Rivet",
                    Localizer.DoStr("Rivet"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<RivetItem>(3),  
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(140, typeof(AdvancedSmeltingSkill), typeof(RivetRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RivetRecipe), this.UILink(), 0.8f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Rivet"), typeof(RivetRecipe));

            CraftingComponent.AddRecipe(typeof(BlastFurnaceObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Rivet")]
    [Weight(2000)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class RivetItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A useful iron bolt for holding together inventions."); } }
    }
}
