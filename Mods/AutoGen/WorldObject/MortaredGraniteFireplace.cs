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
    [RequireComponent(typeof(LinkComponent))]                   
    [RequireComponent(typeof(FuelSupplyComponent))]                      
    [RequireComponent(typeof(FuelConsumptionComponent))]                 
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(SolidGroundComponent))]            
    public partial class MortaredGraniteFireplaceObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Mortared Granite Fireplace"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Stone; 

        public virtual Type RepresentedItemType { get { return typeof(MortaredGraniteFireplaceItem); } } 


        private static string[] fuelTagList = new string[]
        {
            "Burnable Fuel"
        };

        protected override void Initialize()
        {

            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);                            
            this.GetComponent<FuelConsumptionComponent>().Initialize(1);                    
            this.GetComponent<HousingComponent>().Set(MortaredGraniteFireplaceItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Mortared Granite Fireplace")]
    [Ecopedia("Housing Objects", "Decoration", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class MortaredGraniteFireplaceItem :
        WorldObjectItem<MortaredGraniteFireplaceObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A basic stone fireplace. Not much to look at it but a great source of heat."); } }

        static MortaredGraniteFireplaceItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 1.5f,                                   
                                                    TypeForRoomLimit = "Fireplace", 
                                                    DiminishingReturnPercent = 0.1f    
        };}}
        
        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(1)}w of {new HeatPower().Name} power from fuel"); 

    }

    [RequiresSkill(typeof(MasonrySkill), 5)]     
    public partial class MortaredGraniteFireplaceRecipe :
        Recipe
    {
        public MortaredGraniteFireplaceRecipe()
        {
            var product = new Recipe(
                "MortaredGraniteFireplace",
                Localizer.DoStr("Mortared Granite Fireplace"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(MortaredGraniteItem), 40, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),    
                },
               new CraftingElement<MortaredGraniteFireplaceItem>()
            );
            CraftingComponent.AddTagProduct(typeof(MasonryTableObject), typeof(MortaredStoneFireplaceRecipe), product);
        }
    }
}