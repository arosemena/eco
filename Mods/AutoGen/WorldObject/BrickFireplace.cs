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
    public partial class BrickFireplaceObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Brick Fireplace"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Brick; 

        public virtual Type RepresentedItemType { get { return typeof(BrickFireplaceItem); } } 


        private static string[] fuelTagList = new string[]
        {
            "Burnable Fuel"
        };

        protected override void Initialize()
        {

            this.GetComponent<FuelSupplyComponent>().Initialize(2, fuelTagList);                            
            this.GetComponent<FuelConsumptionComponent>().Initialize(1);                    
            this.GetComponent<HousingComponent>().Set(BrickFireplaceItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Brick Fireplace")]
    [Ecopedia("Housing Objects", "Decoration", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class BrickFireplaceItem :
        WorldObjectItem<BrickFireplaceObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A rustic brick fireplace. Nothing beats sitting around the fire on a cold day."); } }

        static BrickFireplaceItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 2,                                   
                                                    TypeForRoomLimit = "Fireplace", 
                                                    DiminishingReturnPercent = 0.1f    
        };}}
        
        [Tooltip(7)] private LocString PowerConsumptionTooltip => Localizer.Do($"Consumes: {Text.Info(1)}w of {new HeatPower().Name} power from fuel"); 

    }

    [RequiresSkill(typeof(PotterySkill), 4)]     
    public partial class BrickFireplaceRecipe :
        RecipeFamily
    {
        public BrickFireplaceRecipe()
        {
            var product = new Recipe(
                "BrickFireplace",
                Localizer.DoStr("Brick Fireplace"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(BrickItem), 50, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)), 
               new IngredientElement(typeof(IronBarItem), 20, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),    
                },
               new CraftingElement<BrickFireplaceItem>()
            );
            this.Initialize(Localizer.DoStr("Brick Fireplace"), typeof(BrickFireplaceRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 3;  
            this.LaborInCalories = CreateLaborInCaloriesValue(500, typeof(PotterySkill), typeof(BrickFireplaceRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BrickFireplaceRecipe), this.UILink(), 10, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Brick Fireplace"), typeof(BrickFireplaceRecipe));
            CraftingComponent.AddRecipe(typeof(MasonryTableObject), this);
        }
    }
}
