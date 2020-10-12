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
    using Eco.Gameplay.Modules;
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

    [RequiresSkill(typeof(MiningSkill), 7)]      
    public partial class MiningModernUpgradeRecipe :
        RecipeFamily
    {
        public MiningModernUpgradeRecipe()
        {
            this.Initialize(Localizer.DoStr("Mining Modern Upgrade"), typeof(MiningModernUpgradeRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "MiningModernUpgrade",
                    Localizer.DoStr("Mining Modern Upgrade"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(ModernUpgradeLvl4Item), 1, true),  
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<MiningModernUpgradeItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(15000, typeof(MiningSkill), typeof(MiningModernUpgradeRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(MiningModernUpgradeRecipe), this.UILink(), 18, typeof(MiningSkill));     
            this.Initialize(Localizer.DoStr("Mining Modern Upgrade"), typeof(MiningModernUpgradeRecipe));

            CraftingComponent.AddRecipe(typeof(FrothFloatationCellObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Mining Modern Upgrade")]
    [Weight(1)]      
    [Ecopedia("Upgrade Modules", "Specialty Upgrades", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Upgrade", 1)]
    public partial class MiningModernUpgradeItem :
        EfficiencyModule 
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Modern Upgrade that greatly increases efficiency when crafting Mining recipes."); } }

        public MiningModernUpgradeItem() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.5f + 0.05f, 
            typeof(MiningSkill),   
            0.5f          
        ) { }
    }
}
