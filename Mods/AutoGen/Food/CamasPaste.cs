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
    [LocDisplayName("Camas Paste")]
    [Weight(100)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CamasPasteItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Camas Paste"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Pulverized camas works as an excellent thickener or flavour enhancer."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 3, Fat = 10, Protein = 2, Vitamins = 0};
        public override float Calories                          { get { return 60; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(MillingSkill), 1)]    
    public partial class CamasPasteRecipe :
        RecipeFamily
    {
        public CamasPasteRecipe()
        {
            var product = new Recipe(
                "CamasPaste",
                Localizer.DoStr("Camas Paste"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(CamasBulbItem), 4, typeof(MillingSkill), typeof(MillingLavishResourcesTalent)),   
                },
                    new CraftingElement<CamasPasteItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Camas Paste"), typeof(CamasPasteRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(MillingSkill), typeof(CamasPasteRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CamasPasteRecipe), this.UILink(), 2, typeof(MillingSkill), typeof(MillingFocusedSpeedTalent), typeof(MillingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Camas Paste"), typeof(CamasPasteRecipe));
            CraftingComponent.AddRecipe(typeof(MillObject), this);
        }
    }
}
