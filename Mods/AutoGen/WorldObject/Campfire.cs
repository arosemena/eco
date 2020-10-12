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
    [RequireComponent(typeof(PropertyAuthComponent))]
    [RequireComponent(typeof(MinimapComponent))]                
    [RequireComponent(typeof(LinkComponent))]                   
    [RequireComponent(typeof(CraftingComponent))]               
    [RequireComponent(typeof(FuelSupplyComponent))]                      
    [RequireComponent(typeof(FuelConsumptionComponent))]                 
    [RequireComponent(typeof(SolidGroundComponent))]            
    [RequireComponent(typeof(PluginModulesComponent))]           
    public partial class CampfireObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Campfire"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Stone; 

        public virtual Type RepresentedItemType { get { return typeof(CampfireItem); } } 


        private static string[] fuelTagList = new string[]
        {
            "Burnable Fuel"
        };

        protected override void Initialize()
        {

            this.GetComponent<MinimapComponent>().Initialize(Localizer.DoStr("Cooking"));                
            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);                            
            this.GetComponent<FuelConsumptionComponent>().Initialize(10);                    

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Campfire")]
    [Ecopedia("Work Stations", "Craft Tables", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [AllowPluginModules(Tags = new[] { "BasicUpgrade", }, ItemTypes = new[] { typeof(CampfireCookingUpgradeItem), })]  
    public partial class CampfireItem :
        WorldObjectItem<CampfireObject> 
        ,IPersistentData 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Cook like a caveman on an uneven fire."); } }

        static CampfireItem()
        {
            
        }

        
        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(10)}w of {new HeatPower().Name} power from fuel"); 

        [Serialized, TooltipChildren] public object PersistentData { get; set; } 
    }

    public partial class CampfireRecipe :
        RecipeFamily
    {
        public CampfireRecipe()
        {
            var product = new Recipe(
                "Campfire",
                Localizer.DoStr("Campfire"),
                new IngredientElement[]
                {
               new IngredientElement("Wood", 3), 
               new IngredientElement("Rock", 12),   
                },
               new CraftingElement<CampfireItem>()
            );
            this.Initialize(Localizer.DoStr("Campfire"), typeof(CampfireRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(35); 
            this.CraftMinutes = CreateCraftTimeValue(1);
            this.Initialize(Localizer.DoStr("Campfire"), typeof(CampfireRecipe));
            CraftingComponent.AddRecipe(typeof(CampsiteObject), this);
            CraftingComponent.AddRecipe(typeof(WorkbenchObject), this);
        }
    }
}