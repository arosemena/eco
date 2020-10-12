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
    [LocDisplayName("Bread")]
    [Weight(500)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("Bread", 1)]
    public partial class BreadItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Bread"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A delicious, crispy crust hides the soft interior."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 20, Fat = 10, Protein = 5, Vitamins = 5};
        public override float Calories                          { get { return 750; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(AdvancedBakingSkill), 1)]    
    public partial class BreadRecipe :
        RecipeFamily
    {
        public BreadRecipe()
        {
            var product = new Recipe(
                "Bread",
                Localizer.DoStr("Bread"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(LeavenedDoughItem), 1, typeof(AdvancedBakingSkill), typeof(AdvancedBakingLavishResourcesTalent)),   
                },
                    new CraftingElement<BreadItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Bread"), typeof(BreadRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(AdvancedBakingSkill), typeof(BreadRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(BreadRecipe), this.UILink(), 3, typeof(AdvancedBakingSkill), typeof(AdvancedBakingFocusedSpeedTalent), typeof(AdvancedBakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Bread"), typeof(BreadRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}
