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
    [RequireComponent(typeof(FuelSupplyComponent))]                      
    [RequireComponent(typeof(FuelConsumptionComponent))]                 
    [RequireComponent(typeof(HousingComponent))]                  
    public partial class CeilingCandleObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Ceiling Candle"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Metal; 

        public virtual Type RepresentedItemType { get { return typeof(CeilingCandleItem); } } 


        private static string[] fuelTagList = new string[]
        {
            "Fat"
        };

        protected override void Initialize()
        {

            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);                            
            this.GetComponent<FuelConsumptionComponent>().Initialize(1);                    
            this.GetComponent<HousingComponent>().Set(CeilingCandleItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Ceiling Candle")]
    [Ecopedia("Housing Objects", "Lights", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class CeilingCandleItem :
        WorldObjectItem<CeilingCandleObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A fancy hanging candelabra."); } }

        static CeilingCandleItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 1.4f,                                   
                                                    TypeForRoomLimit = "Lights", 
                                                    DiminishingReturnPercent = 0.7f    
        };}}
        
        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(1)}w of {new HeatPower().Name} power from fuel"); 

    }

    [RequiresSkill(typeof(SmeltingSkill), 3)]     
    public partial class CeilingCandleRecipe :
        RecipeFamily
    {
        public CeilingCandleRecipe()
        {
            var product = new Recipe(
                "CeilingCandle",
                Localizer.DoStr("Ceiling Candle"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(IronBarItem), 3, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(TallowItem), 2, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
                },
               new CraftingElement<CeilingCandleItem>()
            );
            this.Initialize(Localizer.DoStr("Ceiling Candle"), typeof(CeilingCandleRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 3;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(SmeltingSkill), typeof(CeilingCandleRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CeilingCandleRecipe), this.UILink(), 4, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Ceiling Candle"), typeof(CeilingCandleRecipe));
            CraftingComponent.AddRecipe(typeof(AnvilObject), this);
        }
    }
}