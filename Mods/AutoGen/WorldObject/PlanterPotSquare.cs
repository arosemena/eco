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
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(SolidGroundComponent))]            
    [RequireComponent(typeof(FakePlantComponent))]              
    public partial class PlanterPotSquareObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Square Pot"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Brick; 

        public virtual Type RepresentedItemType { get { return typeof(PlanterPotSquareItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(PlanterPotSquareItem.HousingVal);                               
            this.GetComponent<FakePlantComponent>().Initialize();                                           

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Square Pot")]
    [Ecopedia("Housing Objects", "Decoration", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class PlanterPotSquareItem :
        WorldObjectItem<PlanterPotSquareObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Sometimes you just want to bring a little bit of nature into your house."); } }

        static PlanterPotSquareItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 1,                                   
                                                    TypeForRoomLimit = "Decoration", 
                                                    DiminishingReturnPercent = 0.4f    
        };}}
        

    }

    [RequiresSkill(typeof(PotterySkill), 3)]     
    public partial class PlanterPotSquareRecipe :
        RecipeFamily
    {
        public PlanterPotSquareRecipe()
        {
            var product = new Recipe(
                "PlanterPotSquare",
                Localizer.DoStr("Square Pot"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(ClayItem), 4, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),    
                },
               new CraftingElement<PlanterPotSquareItem>()
            );
            this.Initialize(Localizer.DoStr("Square Pot"), typeof(PlanterPotSquareRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(75, typeof(PotterySkill), typeof(PlanterPotSquareRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(PlanterPotSquareRecipe), this.UILink(), 2, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Square Pot"), typeof(PlanterPotSquareRecipe));
            CraftingComponent.AddRecipe(typeof(KilnObject), this);
        }
    }
}