﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(CarpentrySkill), 1)]      
    [Category("Hidden"), Tag("NotInBrowser")]                                    
    public partial class SmallStandingWoodSignRecipe :
        RecipeFamily
    {
        public SmallStandingWoodSignRecipe()
        {
			CraftableDefault = false; 
            this.Initialize(Localizer.DoStr("Small Standing Wood Sign"), typeof(SmallStandingWoodSignRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SmallStandingWoodSign",
                    Localizer.DoStr("Small Standing Wood Sign"),
                    new IngredientElement[]
                    {
                    new IngredientElement("WoodBoard", 2, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), 
                    new IngredientElement("HewnLog", 4, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), 
                    new IngredientElement("Wood", 5, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SmallStandingWoodSignItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 1;  

            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(CarpentrySkill), typeof(SmallStandingWoodSignRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SmallStandingWoodSignRecipe), this.UILink(), 2, typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Small Standing Wood Sign"), typeof(SmallStandingWoodSignRecipe));

            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Small Standing Wood Sign")]
    [Category("Hidden")]    
    public partial class SmallStandingWoodSignItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A small sign for all of your smaller text needs!"); } }
    }
}