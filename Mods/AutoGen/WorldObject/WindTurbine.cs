﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
      using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Economy;
    using Eco.Gameplay.Housing;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Modules;
    using Eco.Gameplay.Minimap;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Gameplay.Pipes.LiquidComponents;
    using Eco.Gameplay.Pipes.Gases;
    using Eco.Gameplay.Systems.Tooltip;
    using Eco.Shared;
    using Eco.Shared.Math;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Shared.Items;
    using Eco.Gameplay.Pipes;
    using Eco.World.Blocks;
    
    [Serialized]
    [RequireComponent(typeof(OnOffComponent))]                   
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(PowerGridComponent))]              
    [RequireComponent(typeof(PowerGeneratorComponent))]         
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(SolidGroundComponent))]            
    [PowerGenerator(typeof(ElectricPower))]                 
    public partial class WindTurbineObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Wind Turbine"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Wood; 

        public virtual Type RepresentedItemType { get { return typeof(WindTurbineItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<PowerGridComponent>().Initialize(30, new ElectricPower());        
            this.GetComponent<PowerGeneratorComponent>().Initialize(1000);                       
            this.GetComponent<HousingComponent>().Set(WindTurbineItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Wind Turbine")]
    [Ecopedia("Crafted Objects", "Power Generation", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class WindTurbineItem :
        WorldObjectItem<WindTurbineObject> 
    {
        public override LocString DisplayDescription => Localizer.DoStr("Generates electrical power from the wind.");

        static WindTurbineItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "Industrial",
                                                    TypeForRoomLimit = "", 
        };}}
        
        [Tooltip(8)] private LocString PowerProductionTooltip  => Localizer.Do($"Produces: {Text.Info(1000)}w of {new ElectricPower().Name} power");             

    }

    [RequiresSkill(typeof(ElectronicsSkill), 1)]     
    public partial class WindTurbineRecipe :
        RecipeFamily
    {
        public WindTurbineRecipe()
        {
            var product = new Recipe(
                "WindTurbine",
                Localizer.DoStr("Wind Turbine"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(SteelBarItem), 8, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), 
               new IngredientElement(typeof(GearboxItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)), 
               new IngredientElement(typeof(AdvancedCircuitItem), 4, typeof(ElectronicsSkill), typeof(ElectronicsLavishResourcesTalent)),    
                },
               new CraftingElement<WindTurbineItem>()
            );
            this.Initialize(Localizer.DoStr("Wind Turbine"), typeof(WindTurbineRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 15;  
            this.LaborInCalories = CreateLaborInCaloriesValue(2000, typeof(ElectronicsSkill), typeof(WindTurbineRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(WindTurbineRecipe), this.UILink(), 20, typeof(ElectronicsSkill), typeof(ElectronicsFocusedSpeedTalent), typeof(ElectronicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Wind Turbine"), typeof(WindTurbineRecipe));
            CraftingComponent.AddRecipe(typeof(RoboticAssemblyLineObject), this);
        }
    }
}
