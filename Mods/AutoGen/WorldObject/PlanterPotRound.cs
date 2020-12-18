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
    public partial class PlanterPotRoundObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Round Pot"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Brick; 

        public virtual Type RepresentedItemType { get { return typeof(PlanterPotRoundItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(PlanterPotRoundItem.HousingVal);                               
            this.GetComponent<FakePlantComponent>().Initialize();                                           

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Round Pot")]
    [Ecopedia("Housing Objects", "Decoration", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class PlanterPotRoundItem :
        WorldObjectItem<PlanterPotRoundObject> 
    {
        public override LocString DisplayDescription => Localizer.DoStr("Sometimes you just want to bring a little bit of nature into your house.");

        static PlanterPotRoundItem()
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
    public partial class PlanterPotRoundRecipe :
        RecipeFamily
    {
        public PlanterPotRoundRecipe()
        {
            var product = new Recipe(
                "PlanterPotRound",
                Localizer.DoStr("Round Pot"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(ClayItem), 4, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),    
                },
               new CraftingElement<PlanterPotRoundItem>()
            );
            this.Initialize(Localizer.DoStr("Round Pot"), typeof(PlanterPotRoundRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(75, typeof(PotterySkill), typeof(PlanterPotRoundRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(PlanterPotRoundRecipe), this.UILink(), 2, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Round Pot"), typeof(PlanterPotRoundRecipe));
            CraftingComponent.AddRecipe(typeof(KilnObject), this);
        }
    }
}
