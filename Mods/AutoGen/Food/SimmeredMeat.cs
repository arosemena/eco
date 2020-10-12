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
    [LocDisplayName("Simmered Meat")]
    [Weight(800)]
    [Ecopedia("Food", "Cooking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class SimmeredMeatItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Simmered Meat"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Meat cooked in meat juices keeps the meat juicy."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 6, Fat = 13, Protein = 18, Vitamins = 5};
        public override float Calories                          { get { return 900; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CookingSkill), 2)]    
    public partial class SimmeredMeatRecipe :
        RecipeFamily
    {
        public SimmeredMeatRecipe()
        {
            var product = new Recipe(
                "SimmeredMeat",
                Localizer.DoStr("Simmered Meat"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(PreparedMeatItem), 2, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)), 
            new IngredientElement(typeof(MeatStockItem), 1, typeof(CookingSkill), typeof(CookingLavishResourcesTalent)),   
                },
                    new CraftingElement<SimmeredMeatItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Simmered Meat"), typeof(SimmeredMeatRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CookingSkill), typeof(SimmeredMeatRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SimmeredMeatRecipe), this.UILink(), 4, typeof(CookingSkill), typeof(CookingFocusedSpeedTalent), typeof(CookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Simmered Meat"), typeof(SimmeredMeatRecipe));
            CraftingComponent.AddRecipe(typeof(CastIronStoveObject), this);
        }
    }
}