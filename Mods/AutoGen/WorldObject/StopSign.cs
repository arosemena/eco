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
    [RequireComponent(typeof(SolidGroundComponent))]            
    public partial class StopSignObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Stop Sign"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Metal; 

        public virtual Type RepresentedItemType { get { return typeof(StopSignItem); } } 



        protected override void Initialize()
        {


        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Stop Sign")]
    [Ecopedia("Crafted Objects", "Community", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class StopSignItem :
        WorldObjectItem<StopSignObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A traffic sign used to notify drivers to come to a complete stop and make sure the interesection is clear before proceeding."); } }

        static StopSignItem()
        {
            
        }

        

    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 1)]     
    public partial class StopSignRecipe :
        RecipeFamily
    {
        public StopSignRecipe()
        {
            var product = new Recipe(
                "StopSign",
                Localizer.DoStr("Stop Sign"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(IronBarItem), 8, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),    
                },
               new CraftingElement<StopSignItem>()
            );
            this.Initialize(Localizer.DoStr("Stop Sign"), typeof(StopSignRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(BasicEngineeringSkill), typeof(StopSignRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(StopSignRecipe), this.UILink(), 2, typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Stop Sign"), typeof(StopSignRecipe));
            CraftingComponent.AddRecipe(typeof(WainwrightTableObject), this);
        }
    }
}