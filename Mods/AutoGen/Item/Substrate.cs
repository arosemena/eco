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

    [RequiresSkill(typeof(ElectronicsSkill), 1)]      
    public partial class SubstrateRecipe :
        RecipeFamily
    {
        public SubstrateRecipe()
        {
            this.Initialize(Localizer.DoStr("Substrate"), typeof(SubstrateRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Substrate",
                    Localizer.DoStr("Substrate"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(FiberglassItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), 
                    new IngredientElement(typeof(EpoxyItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SubstrateItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(ElectronicsSkill), typeof(SubstrateRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SubstrateRecipe), this.UILink(), 2, typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Substrate"), typeof(SubstrateRecipe));

            CraftingComponent.AddRecipe(typeof(ElectronicsAssemblyObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Substrate")]
    [Weight(1000)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SubstrateItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("The foundation material for complex electronics."); } }
    }
}