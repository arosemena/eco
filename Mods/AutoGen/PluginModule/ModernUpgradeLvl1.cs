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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 2)]      
    public partial class ModernUpgradeLvl1Recipe :
        RecipeFamily
    {
        public ModernUpgradeLvl1Recipe()
        {
            this.Initialize(Localizer.DoStr("Modern Upgrade 1"), typeof(ModernUpgradeLvl1Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ModernUpgradeLvl1",
                    Localizer.DoStr("Modern Upgrade 1"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(SteelBarItem), 6, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(RivetItem), 20, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),   
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<ModernUpgradeLvl1Item>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(AdvancedSmeltingSkill), typeof(ModernUpgradeLvl1Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ModernUpgradeLvl1Recipe), this.UILink(), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Modern Upgrade 1"), typeof(ModernUpgradeLvl1Recipe));

            CraftingComponent.AddRecipe(typeof(BlastFurnaceObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Modern Upgrade 1")]
    [Weight(1)]      
    [Ecopedia("Upgrade Modules", "Modern Upgrades", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Upgrade", 1)]
    [Tag("ModernUpgrade", 1)]                                 
    public partial class ModernUpgradeLvl1Item :
        EfficiencyModule 
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Modern Upgrade 1"); } } 
        public override LocString DisplayDescription { get { return Localizer.DoStr("Modern Upgrade with great efficiency increase."); } }

        public ModernUpgradeLvl1Item() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.9f          
        ) { }
    }
}
