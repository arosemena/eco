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
    [RequireComponent(typeof(AirPollutionComponent))]           
    [RequireComponent(typeof(OnOffComponent))]                  
    [RequireComponent(typeof(ChimneyComponent))]                
    [RequireComponent(typeof(LiquidProducerComponent))]         
    [RequireComponent(typeof(AttachmentComponent))]             
    [RequireComponent(typeof(OnOffComponent))]                   
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(LinkComponent))]                   
    [RequireComponent(typeof(FuelSupplyComponent))]                      
    [RequireComponent(typeof(FuelConsumptionComponent))]                 
    [RequireComponent(typeof(PowerGridComponent))]              
    [RequireComponent(typeof(PowerGeneratorComponent))]         
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(SolidGroundComponent))]            
    [RequireComponent(typeof(LiquidConverterComponent))]        
    [PowerGenerator(typeof(ElectricPower))]                 
    public partial class CombustionGeneratorObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Combustion Generator"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Metal; 

        public virtual Type RepresentedItemType { get { return typeof(CombustionGeneratorItem); } } 


        private static string[] fuelTagList = new string[]
        {
            "Liquid Fuel"
        };

        protected override void Initialize()
        {

            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);                            
            this.GetComponent<FuelConsumptionComponent>().Initialize(75);                    
            this.GetComponent<PowerGridComponent>().Initialize(30, new ElectricPower());        
            this.GetComponent<PowerGeneratorComponent>().Initialize(3000);                       
            this.GetComponent<HousingComponent>().Set(CombustionGeneratorItem.HousingVal);                               

            this.GetComponent<LiquidProducerComponent>().Setup(typeof(SmogItem), 1.2f, this.NamedOccupancyOffset("ChimneyOut"));  
            this.GetComponent<AirPollutionComponent>().Initialize(this.GetComponent<LiquidProducerComponent>());  
            this.GetComponent<LiquidConverterComponent>().Setup(typeof(WaterItem), typeof(SewageItem), this.NamedOccupancyOffset("WaterInputPort"), this.NamedOccupancyOffset("SewageOutputPort"), 0.3f, 0.9f); 
        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Combustion Generator")]
    [Ecopedia("Crafted Objects", "Power Generation", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [LiquidProducer(typeof(SmogItem), 1.2f)] 
    public partial class CombustionGeneratorItem :
        WorldObjectItem<CombustionGeneratorObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Consumes most fuels to produce energy."); } }

        static CombustionGeneratorItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "Industrial",
                                                    TypeForRoomLimit = "", 
        };}}
        
        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(75)}w of {new ElectricPower().Name} power from fuel"); 
        [Tooltip(8)] private LocString PowerProductionTooltip  => Localizer.Do($"Produces: {Text.Info(3000)}w of {new ElectricPower().Name} power");             

    }

    [RequiresSkill(typeof(MechanicsSkill), 1)]     
    public partial class CombustionGeneratorRecipe :
        RecipeFamily
    {
        public CombustionGeneratorRecipe()
        {
            var product = new Recipe(
                "CombustionGenerator",
                Localizer.DoStr("Combustion Generator"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(PistonItem), 4, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)), 
               new IngredientElement(typeof(IronBarItem), 12, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),    
               new IngredientElement(typeof(CombustionEngineItem), 1, true),  
                },
               new CraftingElement<CombustionGeneratorItem>()
            );
            this.Initialize(Localizer.DoStr("Combustion Generator"), typeof(CombustionGeneratorRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 25;  
            this.LaborInCalories = CreateLaborInCaloriesValue(1000, typeof(MechanicsSkill), typeof(CombustionGeneratorRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CombustionGeneratorRecipe), this.UILink(), 15, typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Combustion Generator"), typeof(CombustionGeneratorRecipe));
            CraftingComponent.AddRecipe(typeof(ElectricMachinistTableObject), this);
        }
    }
}