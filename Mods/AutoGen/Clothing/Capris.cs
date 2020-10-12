﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    
    [Serialized]
    [LocDisplayName("Capris")]
    [Weight(100)]
    [Tag("Clothes", 1)]
    [Ecopedia("Items", "Clothing", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CaprisItem :
        ClothingItem        
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Capri pants (also known as three quarter pants, capris, crop pants, pedal pushers, clam-diggers, flood pants, jams, highwaters, culottes, or toreador pants) are pants that are longer than shorts but are not as long as trousers."); } }
        public override string Slot             { get { return ClothingSlot.Pants; } }             
        public override bool Starter            { get { return true ; } }                       

    }

    
    [RequiresSkill(typeof(TailoringSkill), 1)]
    public class CaprisRecipe : RecipeFamily
    {
        public CaprisRecipe()
        {
            this.Initialize(Localizer.DoStr("Capris"), typeof(CaprisRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Capris",
                    Localizer.DoStr("Capris"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(LeatherHideItem), 3, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)), 
               new IngredientElement(typeof(PlantFibersItem), 20, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),   
                    },
                new CraftingElement<CaprisItem>()
                )
            };

            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(TailoringSkill), typeof(CaprisRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CaprisRecipe), this.UILink(), 10, typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent)); 
            this.Initialize(Localizer.DoStr("Capris"), typeof(CaprisRecipe));
            CraftingComponent.AddRecipe(typeof(TailoringTableObject), this);
        }
    } 
}