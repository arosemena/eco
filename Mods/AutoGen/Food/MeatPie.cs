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
    [LocDisplayName("Meat Pie")]
    [Weight(600)]
    [Ecopedia("Food", "Baking", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class MeatPieItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Much like a huckleberry pie, but filled to the brim with succulent meat."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 7, Fat = 13, Protein = 13, Vitamins = 5};
        public override float Calories                          { get { return 1300; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(BakingSkill), 3)]    
    public partial class MeatPieRecipe :
        RecipeFamily
    {
        public MeatPieRecipe()
        {
            var product = new Recipe(
                "MeatPie",
                Localizer.DoStr("Meat Pie"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(FlourItem), 4, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)), 
            new IngredientElement(typeof(ScrapMeatItem), 12, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
            new IngredientElement("Fat", 2, typeof(BakingSkill), typeof(BakingLavishResourcesTalent)),   
                },
                    new CraftingElement<MeatPieItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Meat Pie"), typeof(MeatPieRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(BakingSkill), typeof(MeatPieRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(MeatPieRecipe), this.UILink(), 2, typeof(BakingSkill), typeof(BakingFocusedSpeedTalent), typeof(BakingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Meat Pie"), typeof(MeatPieRecipe));
            CraftingComponent.AddRecipe(typeof(BakeryOvenObject), this);
        }
    }
}
