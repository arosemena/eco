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
    [RequireComponent(typeof(MountComponent))]                  
    public partial class CompositeJoshuaBenchObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Composite Joshua Bench"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Wood; 

        public virtual Type RepresentedItemType { get { return typeof(CompositeJoshuaBenchItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(CompositeJoshuaBenchItem.HousingVal);                               
            this.GetComponent<MountComponent>().Initialize(1);                             

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Composite Joshua Bench")]
    [Ecopedia("Housing Objects", "Seating", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class CompositeJoshuaBenchItem :
        WorldObjectItem<CompositeJoshuaBenchObject> 
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("A composite bench built to last."); } }

        static CompositeJoshuaBenchItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 2.5f,                                   
                                                    TypeForRoomLimit = "Seating", 
                                                    DiminishingReturnPercent = 0.5f    
        };}}
        

    }

    [RequiresSkill(typeof(CompositesSkill), 3)]     
    public partial class CompositeJoshuaBenchRecipe :
        Recipe
    {
        public CompositeJoshuaBenchRecipe()
        {
            var product = new Recipe(
                "CompositeJoshuaBench",
                Localizer.DoStr("Composite Joshua Bench"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(CompositeJoshuaLumberItem), 6, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)), 
               new IngredientElement(typeof(ScrewsItem), 6, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),    
                },
               new CraftingElement<CompositeJoshuaBenchItem>()
            );
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberBenchRecipe), product);
        }
    }
}
