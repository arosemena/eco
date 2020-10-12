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
    [RequireComponent(typeof(CustomTextComponent))]              
    public partial class LargeHangingLumberSignObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Large Hanging Lumber Sign"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Wood; 

        public virtual Type RepresentedItemType { get { return typeof(LargeHangingLumberSignItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<CustomTextComponent>().Initialize(700);                                       

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Large Hanging Lumber Sign")]
    [Ecopedia("Crafted Objects", "Signs", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class LargeHangingLumberSignItem :
        WorldObjectItem<LargeHangingLumberSignObject> 
        ,IPersistentData 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A large sign for all your large text needs!"); } }

        static LargeHangingLumberSignItem()
        {
            
        }

        

        [Serialized, TooltipChildren] public object PersistentData { get; set; } 
    }

    [RequiresSkill(typeof(CarpentrySkill), 6)]     
    public partial class LargeHangingLumberSignRecipe :
        RecipeFamily
    {
        public LargeHangingLumberSignRecipe()
        {
            var product = new Recipe(
                "LargeHangingLumberSign",
                Localizer.DoStr("Large Hanging Lumber Sign"),
                new IngredientElement[]
                {
               new IngredientElement("Lumber", 8, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), 
               new IngredientElement("WoodBoard", 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),    
                },
               new CraftingElement<LargeHangingLumberSignItem>()
            );
            this.Initialize(Localizer.DoStr("Large Hanging Lumber Sign"), typeof(LargeHangingLumberSignRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 3;  
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(CarpentrySkill), typeof(LargeHangingLumberSignRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(LargeHangingLumberSignRecipe), this.UILink(), 5, typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Large Hanging Lumber Sign"), typeof(LargeHangingLumberSignRecipe));
            CraftingComponent.AddRecipe(typeof(SawmillObject), this);
        }
    }
}
