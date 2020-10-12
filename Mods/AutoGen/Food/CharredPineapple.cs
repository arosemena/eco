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
    [LocDisplayName("Charred Pineapple")]
    [Weight(100)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("CharredFruit", 1)]
    public partial class CharredPineappleItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Pineapple that has been charred over a basic campfire."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 8, Fat = 0, Protein = 1, Vitamins = 3};
        public override float Calories                          { get { return 350; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]    
    public partial class CharredPineappleRecipe :
        RecipeFamily
    {
        public CharredPineappleRecipe()
        {
            var product = new Recipe(
                "CharredPineapple",
                Localizer.DoStr("Charred Pineapple"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(PineappleItem), 1, true),  
                },
                    new CraftingElement<CharredPineappleItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Charred Pineapple"), typeof(CharredPineappleRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill), typeof(CharredPineappleRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredPineappleRecipe), this.UILink(), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Charred Pineapple"), typeof(CharredPineappleRecipe));
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}