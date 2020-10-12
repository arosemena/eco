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

    [RequiresSkill(typeof(BasicEngineeringSkill), 1)]      
    public partial class WoodenWheelRecipe :
        RecipeFamily
    {
        public WoodenWheelRecipe()
        {
            this.Initialize(Localizer.DoStr("Wooden Wheel"), typeof(WoodenWheelRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "WoodenWheel",
                    Localizer.DoStr("Wooden Wheel"),
                    new IngredientElement[]
                    {
                    new IngredientElement("HewnLog", 4, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<WoodenWheelItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(BasicEngineeringSkill), typeof(WoodenWheelRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(WoodenWheelRecipe), this.UILink(), 2, typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Wooden Wheel"), typeof(WoodenWheelRecipe));

            CraftingComponent.AddRecipe(typeof(WainwrightTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Wooden Wheel")]
    [Weight(500)]      
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class WoodenWheelItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A basic wheel for use in early wooden vehicles."); } }
    }
}