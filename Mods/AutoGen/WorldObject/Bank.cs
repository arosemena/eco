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
    [RequireRoomMaterialTier(1.5f)]  
    public partial class BankObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Bank"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Paper; 

        public virtual Type RepresentedItemType { get { return typeof(BankItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<MinimapComponent>().Initialize(Localizer.DoStr("Economy"));                

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Bank")]
    [Ecopedia("Work Stations", "Economic", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class BankItem :
        WorldObjectItem<BankObject> 
        ,IPersistentData 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Allows players to create and use bank accounts."); } }

        static BankItem()
        {
            
        }

        

        [Serialized, TooltipChildren] public object PersistentData { get; set; } 
    }

    [RequiresSkill(typeof(SmeltingSkill), 1)]     
    public partial class BankRecipe :
        RecipeFamily
    {
        public BankRecipe()
        {
            var product = new Recipe(
                "Bank",
                Localizer.DoStr("Bank"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(GoldBarItem), 12, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(IronBarItem), 16, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(BrickItem), 16, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
               new IngredientElement("Lumber", 16, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),    
                },
               new CraftingElement<BankItem>()
            );
            this.Initialize(Localizer.DoStr("Bank"), typeof(BankRecipe));
            this.Recipes = new List<Recipe> { product };
            this.ExperienceOnCraft = 30;  
            this.LaborInCalories = CreateLaborInCaloriesValue(2500, typeof(SmeltingSkill), typeof(BankRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BankRecipe), this.UILink(), 15, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Bank"), typeof(BankRecipe));
            CraftingComponent.AddRecipe(typeof(AnvilObject), this);
        }
    }
}