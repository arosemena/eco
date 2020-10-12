﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.EcopediaRoot;

    [Serialized]
    [LocDisplayName("Baked Agave")]
    [Weight(300)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("BakedVegetable", 1)]
    [Tag("BakedFood", 1)]
    public partial class BakedAgaveItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Charred agave leaves are too fiberous to eat entirely, but you can certainly chew them."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 12, Fat = 6, Protein = 2, Vitamins = 8};
        public override float Calories                          { get { return 560; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(BakingSkill), 1)]    
    public partial class BakedAgaveRecipe :
        RecipeFamily
    {
        public BakedAgaveRecipe()
        {
            var product = new Recipe(
                "BakedAgave",
                Localizer.DoStr("Baked Agave"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(AgaveLeavesItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                    new CraftingElement<BakedAgaveItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Baked Agave"), typeof(BakedAgaveRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BakingSkill), typeof(BakedAgaveRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BakedAgaveRecipe), this.UILink(), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Baked Agave"), typeof(BakedAgaveRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}
