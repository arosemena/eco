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
    [LocDisplayName("Charred Camas Bulb")]
    [Weight(100)]
    [Ecopedia("Food", "Charred Food", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Tag("CharredVegetable", 1)]
    public partial class CharredCamasBulbItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("A fibrous and sweet treat much like a sweet potato, though slightly blackened over the heat of a campfire."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 2, Fat = 6, Protein = 3, Vitamins = 1};
        public override float Calories                          { get { return 350; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

    [RequiresSkill(typeof(CampfireCookingSkill), 0)]    
    public partial class CharredCamasBulbRecipe :
        RecipeFamily
    {
        public CharredCamasBulbRecipe()
        {
            var product = new Recipe(
                "CharredCamasBulb",
                Localizer.DoStr("Charred Camas Bulb"),
                new IngredientElement[]
                {
            new IngredientElement(typeof(CamasBulbItem), 1, true),  
                },
                    new CraftingElement<CharredCamasBulbItem>(1)  
                
            );
            this.Initialize(Localizer.DoStr("Charred Camas Bulb"), typeof(CharredCamasBulbRecipe));
            this.Recipes = new List<Recipe> { product };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(CampfireCookingSkill), typeof(CharredCamasBulbRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CharredCamasBulbRecipe), this.UILink(), 0.5f, typeof(CampfireCookingSkill), typeof(CampfireCookingFocusedSpeedTalent), typeof(CampfireCookingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Charred Camas Bulb"), typeof(CharredCamasBulbRecipe));
            CraftingComponent.AddRecipe(typeof(CampfireObject), this);
        }
    }
}
