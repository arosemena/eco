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

    [RequiresSkill(typeof(OilDrillingSkill), 1)]      
    public partial class FiberglassRecipe :
        RecipeFamily
    {
        public FiberglassRecipe()
        {
            this.Initialize(Localizer.DoStr("Fiberglass"), typeof(FiberglassRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Fiberglass",
                    Localizer.DoStr("Fiberglass"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(PlasticItem), 4, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)), 
                    new IngredientElement(typeof(GlassItem), 3, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<FiberglassItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(75, typeof(OilDrillingSkill), typeof(FiberglassRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(FiberglassRecipe), this.UILink(), 2, typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Fiberglass"), typeof(FiberglassRecipe));

            CraftingComponent.AddRecipe(typeof(ElectronicsAssemblyObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Fiberglass")]
    [Weight(1000)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class FiberglassItem :
    Item                                    
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Fiberglass"); } } 
        public override LocString DisplayDescription { get { return Localizer.DoStr("Plastic reinforced with glass fiber strands."); } }
    }
}
