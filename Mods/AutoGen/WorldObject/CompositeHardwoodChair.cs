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
    public partial class CompositeHardwoodChairObject : 
        WorldObject,    
        IRepresentsItem
    {
        public override LocString DisplayName { get { return Localizer.DoStr("Composite Hardwood Chair"); } } 

        public override TableTextureMode TableTexture => TableTextureMode.Wood; 

        public virtual Type RepresentedItemType { get { return typeof(CompositeHardwoodChairItem); } } 



        protected override void Initialize()
        {

            this.GetComponent<HousingComponent>().Set(CompositeHardwoodChairItem.HousingVal);                               
            this.GetComponent<MountComponent>().Initialize(1);                             

        }

        public override void Destroy()
        {
            base.Destroy();
        }
       
    }

    [Serialized]
    [LocDisplayName("Composite Hardwood Chair")]
    [Ecopedia("Housing Objects", "Seating", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Housing", 1)]
    public partial class CompositeHardwoodChairItem :
        WorldObjectItem<CompositeHardwoodChairObject> 
    {
        public override LocString DisplayDescription => Localizer.DoStr("A composite chair built to last.");

        static CompositeHardwoodChairItem()
        {
            
        }

        [TooltipChildren] public HousingValue HousingTooltip { get { return HousingVal; } }
        [TooltipChildren] public static HousingValue HousingVal { get { return new HousingValue() 
                                                {
                                                    Category = "General",
                                                    Val = 1.7f,                                   
                                                    TypeForRoomLimit = "Seating", 
                                                    DiminishingReturnPercent = 0.7f    
        };}}
        

    }

    [RequiresSkill(typeof(CompositesSkill), 1)]     
    public partial class CompositeHardwoodChairRecipe :
        Recipe
    {
        public CompositeHardwoodChairRecipe()
        {
            var product = new Recipe(
                "CompositeHardwoodChair",
                Localizer.DoStr("Composite Hardwood Chair"),
                new IngredientElement[]
                {
               new IngredientElement(typeof(ScrewsItem), 6, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),    
               new IngredientElement("HardwoodLumber", 4, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),    
                },
               new CraftingElement<CompositeHardwoodChairItem>()
            );
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberChairRecipe), product);
        }
    }
}
