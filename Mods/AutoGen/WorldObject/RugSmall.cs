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
    public partial class RugSmallObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Rug Small"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Canvas; 

        public virtual Type RepresentedItemType { get { return typeof(RugSmallItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(RugSmallItem.HousingVal);                               

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Rug Small")]
    [Ecopedia("Housing Objects", "Decoration", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class RugSmallItem :
        WorldObjectItem<RugSmallObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A small rug for when you just didn't have enough materials to make a bigger one."); } }

        static RugSmallItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 0.5f,                                   
                                                    TypeForRoomLimit = "Rug", 
                                                    DiminishingReturnPercent = 0.5f    
        };}}
        

    }

    [RequiresSkill(typeof(TailoringSkill), 1)]     
    public partial class RugSmallRecipe :
        RecipeFamily
    {
        public RugSmallRecipe()
        {
            var product = new Recipe(
                "RugSmall",
                Localizer.DoStr("Rug Small"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(ClothItem), 10, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),    
                },
               new CraftingElement<RugSmallItem>()
            );
            this.Initialize(Localizer.DoStr("Rug Small"), typeof(RugSmallRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 2;  
            this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(TailoringSkill), typeof(RugSmallRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RugSmallRecipe), this.UILink(), 6, typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Rug Small"), typeof(RugSmallRecipe));
            CraftingComponent.AddRecipe(typeof(TailoringTableObject), this);
        }
    }
}
