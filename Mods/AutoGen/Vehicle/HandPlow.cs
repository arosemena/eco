﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Components.Auth;
    using Eco.Gameplay.Components.VehicleModules;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Math;
    using Eco.Shared.Networking;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    
    [Serialized]
    [LocDisplayName("Hand Plow")]
    [Weight(15000)]  
    [Ecopedia("Crafted Objects", "Vehicles", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                    
    public partial class HandPlowItem : WorldObjectItem<HandPlowObject>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A tool that tills the field for farming."); } }
    }

    [RequiresSkill(typeof(BasicEngineeringSkill), 2)] 
    public class HandPlowRecipe : RecipeFamily
    {
        public HandPlowRecipe()
        {
            this.Initialize(Localizer.DoStr("Hand Plow"), typeof(HandPlowRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "HandPlow",
                    Localizer.DoStr("Hand Plow"),
                    new IngredientElement[]
                    {
                new IngredientElement(typeof(IronBarItem), 10, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),   
                new IngredientElement("HewnLog", 10, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)), 
                new IngredientElement("WoodBoard", 50, typeof(BasicEngineeringSkill), typeof(BasicEngineeringLavishResourcesTalent)),   
                new IngredientElement(typeof(WoodenWheelItem), 1, true),  
                    },
                new CraftingElement<HandPlowItem>()
                )
            };
            this.ExperienceOnCraft = 10;  
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(BasicEngineeringSkill), typeof(HandPlowRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(HandPlowRecipe), this.UILink(), 2, typeof(BasicEngineeringSkill), typeof(BasicEngineeringFocusedSpeedTalent), typeof(BasicEngineeringParallelSpeedTalent));    

            this.Initialize(Localizer.DoStr("Hand Plow"), typeof(HandPlowRecipe));
            CraftingComponent.AddRecipe(typeof(WainwrightTableObject), this);
        }
    }

    [Serialized]
    [RequireComponent(typeof(StandaloneAuthComponent))]
    [RequireComponent(typeof(VehicleComponent))]
    public partial class HandPlowObject : PhysicsWorldObject, IRepresentsItem
    {
        static HandPlowObject()
        {
            WorldObject.AddOccupancy<HandPlowObject>(new List<BlockOccupancy>(0));
        }

        public override LocString DisplayName { get { return Localizer.DoStr("Hand Plow"); } }
        public Type RepresentedItemType { get { return typeof(HandPlowItem); } }


        private HandPlowObject() { }

        protected override void Initialize()
        {
            base.Initialize();
            
            this.GetComponent<VehicleComponent>().Initialize(10, 1, 1);
            this.GetComponent<VehicleComponent>().HumanPowered(1);           
        }
    }
}
