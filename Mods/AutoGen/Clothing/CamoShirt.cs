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
    [LocDisplayName("Camo Shirt")]
    [Weight(100)]
    [Tag("Clothes", 1)]
    [Ecopedia("Items", "Clothing", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    public partial class CamoShirtItem :
        ClothingItem        
    {
        public override LocString DisplayDescription  { get { return Localizer.DoStr("Hide from the animals!\n\nReduces the detection range of animals."); } }
        public override string Slot             { get { return ClothingSlot.Shirt; } }             
        public override bool Starter            { get { return false ; } }                       

        private static Dictionary<UserStatType, float> flatStats = new Dictionary<UserStatType, float>()
    {
                { UserStatType.DetectionRange, 1 },
    };
public override Dictionary<UserStatType, float> GetFlatStats() { return flatStats; }
    }

    
    [RequiresSkill(typeof(TailoringSkill), 3)]
    public class CamoShirtRecipe : RecipeFamily
    {
        public CamoShirtRecipe()
        {
            this.Initialize(Localizer.DoStr("Camo Shirt"), typeof(CamoShirtRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CamoShirt",
                    Localizer.DoStr("Camo Shirt"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(ClothItem), 20, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)), 
               new IngredientElement(typeof(CelluloseFiberItem), 10, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)), 
               new IngredientElement(typeof(LeatherHideItem), 20, typeof(TailoringSkill), typeof(TailoringLavishResourcesTalent)),   
                    },
                new CraftingElement<CamoShirtItem>()
                )
            };

            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(TailoringSkill), typeof(CamoShirtRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(CamoShirtRecipe), this.UILink(), 1, typeof(TailoringSkill), typeof(TailoringFocusedSpeedTalent), typeof(TailoringParallelSpeedTalent)); 
            this.Initialize(Localizer.DoStr("Camo Shirt"), typeof(CamoShirtRecipe));
            CraftingComponent.AddRecipe(typeof(TailoringTableObject), this);
        }
    } 
}
