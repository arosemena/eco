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

    [RequiresSkill(typeof(CarpentrySkill), 3)]      
    [Category("Hidden"), Tag("NotInBrowser")]                                    
    public partial class LargeHangingWoodSignRecipe :
        RecipeFamily
    {
        public LargeHangingWoodSignRecipe()
        {
			CraftableDefault = false; 
            this.Initialize(Localizer.DoStr("Large Hanging Wood Sign"), typeof(LargeHangingWoodSignRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "LargeHangingWoodSign",
                    Localizer.DoStr("Large Hanging Wood Sign"),
                    new IngredientElement[]
                    {
                    new IngredientElement("WoodBoard", 5, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), 
                    new IngredientElement("HewnLog", 4, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)), 
                    new IngredientElement("Wood", 10, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<LargeHangingWoodSignItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 2;  

            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(CarpentrySkill), typeof(LargeHangingWoodSignRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(LargeHangingWoodSignRecipe), this.UILink(), 3, typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Large Hanging Wood Sign"), typeof(LargeHangingWoodSignRecipe));

            CraftingComponent.AddRecipe(typeof(CarpentryTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Large Hanging Wood Sign")]
    [Category("Hidden")]    
    public partial class LargeHangingWoodSignItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A large sign for all of your larger text needs!"); } }
    }
}
