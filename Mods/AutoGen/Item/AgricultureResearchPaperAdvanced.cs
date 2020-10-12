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

    [RequiresSkill(typeof(FarmingSkill), 0)]      
    public partial class AgricultureResearchPaperAdvancedRecipe :
        RecipeFamily
    {
        public AgricultureResearchPaperAdvancedRecipe()
        {
            this.Initialize(Localizer.DoStr("Agriculture Research Paper Advanced"), typeof(AgricultureResearchPaperAdvancedRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "AgricultureResearchPaperAdvanced",
                    Localizer.DoStr("Agriculture Research Paper Advanced"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(DirtItem), 5, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),    
                    new IngredientElement("Raw Food", 40, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)), 
                    new IngredientElement("Crop Seed", 20, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<AgricultureResearchPaperAdvancedItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 4;  

            this.LaborInCalories = CreateLaborInCaloriesValue(400, typeof(FarmingSkill), typeof(AgricultureResearchPaperAdvancedRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(1);
            this.Initialize(Localizer.DoStr("Agriculture Research Paper Advanced"), typeof(AgricultureResearchPaperAdvancedRecipe));

            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Agriculture Research Paper Advanced")]
    [Weight(10)]      
    [Ecopedia("Items", "Research Papers", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("Advanced Research", 1)]
    [Tag("Research", 1)]                                 
    public partial class AgricultureResearchPaperAdvancedItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A document containing important research information. Used to discover new skills at the research table."); } }
    }
}
