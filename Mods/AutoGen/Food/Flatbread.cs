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
    [LocDisplayName("Flatbread")]
    [Weight(200)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class FlatbreadItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Without any leavening the flatbread isn't very puffy. But it's still tasty."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 17, Fat = 3, Protein = 8, Vitamins = 0};
        public override float Calories                          { get { return 500; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(BakingSkill), 1)]    
    public partial class FlatbreadRecipe :
        RecipeFamily
    {
        public FlatbreadRecipe()
        {
            var product = new Recipe(
                "Flatbread",
                Localizer.DoStr("Flatbread"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(FlourItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                    new CraftingElement<FlatbreadItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Flatbread"), typeof(FlatbreadRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BakingSkill), typeof(FlatbreadRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(FlatbreadRecipe), this.UILink(), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Flatbread"), typeof(FlatbreadRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}