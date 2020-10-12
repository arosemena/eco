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
    [LocDisplayName("Raw Bacon")]
    [Weight(50)]
    [Ecopedia("Food", "Meat", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class RawBaconItem : FoodItem
    {
        public override LocString DisplayNamePlural             { get { return Localizer.DoStr("Raw Bacon"); } } 
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A fatty cut of meat that happens to be inexplicably tastier than other cuts."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 0, Fat = 9, Protein = 3, Vitamins = 0};
        public override float Calories                          { get { return 600; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(ButcherySkill), 2)]    
    public partial class RawBaconRecipe :
        RecipeFamily
    {
        public RawBaconRecipe()
        {
            var product = new Recipe(
                "RawBacon",
                Localizer.DoStr("Raw Bacon"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(RawMeatItem), 4, typeof(ButcherySkill), typeof(ButcheryLavishResourcesTalent)),   
                },
                    new CraftingElement<RawBaconItem>(1),  
                    new CraftingElement<ScrapMeatItem>(5f)  
                
            );
            this.Initialize(Localizer.DoStr("Raw Bacon"), typeof(RawBaconRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(ButcherySkill), typeof(RawBaconRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(RawBaconRecipe), this.UILink(), 0.8f, typeof(ButcherySkill), typeof(ButcheryFocusedSpeedTalent), typeof(ButcheryParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Raw Bacon"), typeof(RawBaconRecipe));
            CraftingComponent.AddRecipe(typeof(ButcheryTableObject), this);
        }
    }
}
