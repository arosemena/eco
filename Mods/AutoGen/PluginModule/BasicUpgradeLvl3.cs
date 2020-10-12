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

    [RequiresSkill(typeof(CarpentrySkill), 5)]      
    public partial class BasicUpgradeLvl3Recipe :
        RecipeFamily
    {
        public BasicUpgradeLvl3Recipe()
        {
            this.Initialize(Localizer.DoStr("Basic Upgrade 3"), typeof(BasicUpgradeLvl3Recipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "BasicUpgradeLvl3",
                    Localizer.DoStr("Basic Upgrade 3"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(PlantFibersItem), 80, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),   
              new IngredientElement("WoodBoard", 20, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),   
               new IngredientElement(typeof(BasicUpgradeLvl2Item), 1, true),  
                    },
                    new CraftingElement[]
                    {
                        new CraftingElement<BasicUpgradeLvl3Item>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(CarpentrySkill), typeof(BasicUpgradeLvl3Recipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BasicUpgradeLvl3Recipe), this.UILink(), 6, typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Basic Upgrade 3"), typeof(BasicUpgradeLvl3Recipe));

            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Basic Upgrade 3")]
    [Weight(1)]      
    [Ecopedia("Upgrade Modules", "Basic Upgrades", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Upgrade", 1)]
    [Tag("BasicUpgrade", 1)]                                 
    public partial class BasicUpgradeLvl3Item :
        EfficiencyModule 
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Basic Upgrade 3"); } } 
        public override LocString DisplayDescription { get { return Localizer.DoStr("Basic Upgrade that increases crafting efficiency."); } }

        public BasicUpgradeLvl3Item() : base(
            ModuleTypes.ResourceEfficiency | ModuleTypes.SpeedEfficiency,
            0.6f          
        ) { }
    }
}