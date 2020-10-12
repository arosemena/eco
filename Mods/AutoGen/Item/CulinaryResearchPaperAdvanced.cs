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

    [RequiresSkill(typeof(BakingSkill), 1)]      
    public partial class CulinaryResearchPaperAdvancedRecipe :
        RecipeFamily
    {
        public CulinaryResearchPaperAdvancedRecipe()
        {
            this.Initialize(Localizer.DoStr("Culinary Research Paper Advanced"), typeof(CulinaryResearchPaperAdvancedRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CulinaryResearchPaperAdvanced",
                    Localizer.DoStr("Culinary Research Paper Advanced"),
                    new IngredientElement[]
                    {
                    new IngredientElement("BakedVegetable", 16, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), 
                    new IngredientElement("Salad", 10, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<CulinaryResearchPaperAdvancedItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(BakingSkill), typeof(CulinaryResearchPaperAdvancedRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(1);
            this.Initialize(Localizer.DoStr("Culinary Research Paper Advanced"), typeof(CulinaryResearchPaperAdvancedRecipe));

            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Culinary Research Paper Advanced")]
    [Weight(10)]      
    [Ecopedia("Items", "Research Papers", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Advanced Research", 1)]
    [Tag("Research", 1)]                                 
    public partial class CulinaryResearchPaperAdvancedItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A document containing important research information. Used to discover new skills at the research table."); } }
    }
}
