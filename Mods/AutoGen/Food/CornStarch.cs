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
    [LocDisplayName("Corn Starch")]
    [Weight(100)]
    [Ecopedia("Food", "Ingredients", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CornStarchItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Obtained from the endosperm of the kernal, cornstarch can be used as a thickening agent for sauces."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0};
        public override float Calories                          { get { return 10; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CuttingEdgeCookingSkill), 1)]    
    public partial class CornStarchRecipe :
        RecipeFamily
    {
        public CornStarchRecipe()
        {
            var product = new Recipe(
                "CornStarch",
                Localizer.DoStr("Corn Starch"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(CornItem), 10, typeof(CuttingEdgeCookingSkill), typeof(CuttingEdgeCookingLavishResourcesTalent)),   
                },
                    new CraftingElement<CornStarchItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Corn Starch"), typeof(CornStarchRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CuttingEdgeCookingSkill), typeof(CornStarchRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CornStarchRecipe), this.UILink(), 8, typeof(CuttingEdgeCookingSkill), typeof(CuttingEdgeCookingFocusedSpeedTalent), typeof(CuttingEdgeCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Corn Starch"), typeof(CornStarchRecipe));
            CraftingComponent.AddRecipe(typeof(LaboratoryObject), this);
        }
    }
}