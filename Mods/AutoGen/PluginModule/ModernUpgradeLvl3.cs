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

    [RequiresSkill(typeof(ElectronicsSkill), 5)]      
    public partial class ModernUpgradeLvl3Recipe :
        RecipeFamily
    {
        public ModernUpgradeLvl3Recipe()
        {
            this.Initialize(Localizer.DoStr("Modern Upgrade 3"), typeof(ModernUpgradeLvl3Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ModernUpgradeLvl3",
                    Localizer.DoStr("Modern Upgrade 3"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(BasicCircuitItem), 8, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), 
               new IngredientElement(typeof(PlasticItem), 15, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), 
               new IngredientElement(typeof(EpoxyItem), 10, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),   
               new IngredientElement(typeof(ModernUpgradeLvl2Item), 1, true),  
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<ModernUpgradeLvl3Item>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(ElectronicsSkill), typeof(ModernUpgradeLvl3Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ModernUpgradeLvl3Recipe), this.UILink(), 10, typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Modern Upgrade 3"), typeof(ModernUpgradeLvl3Recipe));

            CraftingComponent.AddRecipe(typeof(ElectronicsAssemblyObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Modern Upgrade 3")]
    [Weight(1)]      
    [Ecopedia("Upgrade Modules", "Modern Upgrades", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Upgrade", 1)]
    [Tag("ModernUpgrade", 1)]                                 
    public partial class ModernUpgradeLvl3Item :
        EfficiencyModule 
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Modern Upgrade 3"); } } 
        public override LocString DisplayDescription { get { return Localizer.DoStr("Modern Upgrade with great efficiency increase."); } }

        public ModernUpgradeLvl3Item() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.6f          
        ) { }
    }
}