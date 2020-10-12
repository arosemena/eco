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
    [RequireComponent(typeof(SolidGroundComponent))]            
    public partial class SmallStandingAshlarStoneSignObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Small Standing Ashlar Stone Sign"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Stone; 

        public virtual Type RepresentedItemType { get { return typeof(SmallStandingAshlarStoneSignItem); } } 



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
    [LocDisplayName("Small Standing Ashlar Stone Sign")]
    [Ecopedia("Crafted Objects", "Signs", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SmallStandingAshlarStoneSignItem :
        WorldObjectItem<SmallStandingAshlarStoneSignObject> 
        ,IPersistentData 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A small sign for all of your smaller text needs!"); } }

        static SmallStandingAshlarStoneSignItem()
        {
            
        }

        

        [Serialized, TooltipChildren] public object PersistentData { get; set; } 
    }

    [RequiresSkill(typeof(AdvancedMasonrySkill), 1)]     
    public partial class SmallStandingAshlarStoneSignRecipe :
        RecipeFamily
    {
        public SmallStandingAshlarStoneSignRecipe()
        {
            var product = new Recipe(
                "SmallStandingAshlarStoneSign",
                Localizer.DoStr("Small Standing Ashlar Stone Sign"),
                new IngredientElement[]
                {
               new IngredientElement("AshlarStone", 8, typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryLavishResourcesTalent)),    
                },
               new CraftingElement<SmallStandingAshlarStoneSignItem>()
            );
            this.Initialize(Localizer.DoStr("Small Standing Ashlar Stone Sign"), typeof(SmallStandingAshlarStoneSignRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 1;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(AdvancedMasonrySkill), typeof(SmallStandingAshlarStoneSignRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SmallStandingAshlarStoneSignRecipe), this.UILink(), 2, typeof(AdvancedMasonrySkill), typeof(AdvancedMasonryFocusedSpeedTalent), typeof(AdvancedMasonryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Small Standing Ashlar Stone Sign"), typeof(SmallStandingAshlarStoneSignRecipe));
            CraftingComponent.AddRecipe(typeof(AdvancedMasonryTableObject), this);
        }
    }
}
