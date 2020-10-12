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
    [RequireComponent(typeof(HousingComponent))]                  
    [RequireComponent(typeof(SolidGroundComponent))]            
    public partial class BathtubObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Bathtub"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Wood; 

        public virtual Type RepresentedItemType { get { return typeof(BathtubItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(BathtubItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Bathtub")]
    [Ecopedia("Housing Objects", "Washroom", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class BathtubItem :
        WorldObjectItem<BathtubObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A porcelain bathtub for when you need to get clean or just relax"); } }

        static BathtubItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "Bathroom",
                                                    Val = 3,                                   
                                                    TypeForRoomLimit = "Sink", 
                                                    DiminishingReturnPercent = 0.5f    
        };}}
        

    }

    [RequiresSkill(typeof(PotterySkill), 7)]     
    public partial class BathtubRecipe :
        RecipeFamily
    {
        public BathtubRecipe()
        {
            var product = new Recipe(
                "Bathtub",
                Localizer.DoStr("Bathtub"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(ClayItem), 40, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)), 
               new IngredientElement(typeof(IronBarItem), 20, typeof(PotterySkill), typeof(PotteryLavishResourcesTalent)),    
                },
               new CraftingElement<BathtubItem>()
            );
            this.Initialize(Localizer.DoStr("Bathtub"), typeof(BathtubRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 2;  
            this.LaborInCalories = CreateLaborInCaloriesValue(400, typeof(PotterySkill), typeof(BathtubRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BathtubRecipe), this.UILink(), 6, typeof(PotterySkill), typeof(PotteryFocusedSpeedTalent), typeof(PotteryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Bathtub"), typeof(BathtubRecipe));
            CraftingComponent.AddRecipe(typeof(KilnObject), this);
        }
    }
}
