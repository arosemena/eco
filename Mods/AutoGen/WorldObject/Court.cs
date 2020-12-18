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
    [RequireComponent(typeof(SolidGroundComponent))]            
    [RequireComponent(typeof(RoomRequirementsComponent))]
    [RequireRoomContainment]
    [RequireRoomVolume(45)]                          
    [RequireRoomMaterialTier(1)]  
    public partial class CourtObject : 
        CivicObject, 
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Court"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Paper; 

        public virtual Type RepresentedItemType { get { return typeof(CourtItem); } } 



        protected override void Initialize()
        {
            base.Initialize(); 

            this.GetComponent<MinimapComponent>().Initialize(Localizer.DoStr("Civics"));                

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Court")]
    [Ecopedia("Work Stations", "Government", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class CourtItem :
        WorldObjectItem<CourtObject> 
        ,IPersistentData 
    {
        public override LocString DisplayDescription => Localizer.DoStr("A court where laws are decided.");

        static CourtItem()
        {
            
        }

        

        [Serialized, TooltipChildren] public object PersistentData { get; set; } 
    }

    public partial class CourtRecipe :
        RecipeFamily
    {
        public CourtRecipe()
        {
            var product = new Recipe(
                "Court",
                Localizer.DoStr("Court"),
                new IngredientElement[]
                {
               new IngredientElement("HewnLog", 30), 
               new IngredientElement("MortaredStone", 30),   
                },
               new CraftingElement<CourtItem>()
            );
            this.Initialize(Localizer.DoStr("Court"), typeof(CourtRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(2000); 
            this.CraftMinutes = CreateCraftTimeValue(5);
            this.Initialize(Localizer.DoStr("Court"), typeof(CourtRecipe));
            CraftingComponent.AddRecipe(typeof(CapitolObject), this);
        }
    }
}
