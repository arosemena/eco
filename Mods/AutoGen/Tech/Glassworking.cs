﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    using Eco.Shared.Utils;
    using Gameplay.Systems.Tooltip;

    [Serialized]
    [LocDisplayName("Glassworking")]
    [Ecopedia("Professions", "Mason", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]    
    [RequiresSkill(typeof(MasonSkill), 0), Tag("Mason Specialty"), Tier(3)]    
    public partial class GlassworkingSkill : Skill
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Glassworkers have improved ability to create glass which can be used as a clear building material or framed in steel to create a more industrial look. Level by crafting related recipes."); } }

        public override void OnLevelUp(User user)
        {
            user.Skillset.AddExperience(typeof(SelfImprovementSkill), 20, Localizer.DoStr("for leveling up another specialization."));
        }


        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] { 1,
                
                1 - 0.5f,
                
                1 - 0.55f,
                
                1 - 0.6f,
                
                1 - 0.65f,
                
                1 - 0.7f,
                
                1 - 0.75f,
                
                1 - 0.8f,
                
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;
        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] { 0,
                
                0.5f,
                
                0.55f,
                
                0.6f,
                
                0.65f,
                
                0.7f,
                
                0.75f,
                
                0.8f,
                
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public static int[] SkillPointCost = {
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
        };
        public override int RequiredPoint { get { return this.Level < SkillPointCost.Length ? SkillPointCost[this.Level] : 0; } }
        public override int PrevRequiredPoint { get { return this.Level - 1 >= 0 && this.Level - 1 < SkillPointCost.Length ? SkillPointCost[this.Level - 1] : 0; } }
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 3; } }
    }

    [Serialized]
    [LocDisplayName("Glassworking Skill Book")]
    [Ecopedia("Items", "Skill Books", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class GlassworkingSkillBook : SkillBook<GlassworkingSkill, GlassworkingSkillScroll>
    {
    }

    [Serialized]
    [LocDisplayName("Glassworking Skill Scroll")]
    public partial class GlassworkingSkillScroll : SkillScroll<GlassworkingSkill, GlassworkingSkillBook>
    {
    }

    [RequiresSkill(typeof(MasonrySkill), 1)] 
    public partial class GlassworkingSkillBookRecipe : RecipeFamily
    {
        public GlassworkingSkillBookRecipe()
        {
            this.Initialize(Localizer.DoStr("Glassworking"), typeof(GlassworkingSkillBookRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Glassworking",
                    Localizer.DoStr("Glassworking"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(GeologyResearchPaperBasicItem), 10), 
               new IngredientElement(typeof(GeologyResearchPaperAdvancedItem), 5), 
               new IngredientElement(typeof(EngineeringResearchPaperAdvancedItem), 5),  
 new IngredientElement("Basic Research", 10),  
                    },
                new CraftingElement<GlassworkingSkillBook>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(4000); 
            this.CraftMinutes = CreateCraftTimeValue(15);

            this.Initialize(Localizer.DoStr("Glassworking Skill Book"), typeof(GlassworkingSkillBookRecipe));
            CraftingComponent.AddRecipe(typeof(ResearchTableObject), this);
        }
    }
}
