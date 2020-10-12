﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System.Collections.Generic;
    using Eco.Gameplay.Blocks;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Items.SearchAndSelect;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Gameplay.Players;
    using System.ComponentModel;

    [Serialized]
    [LocDisplayName("Amanita Mushroom Spores")]
    [Weight(50)]  
    [StartsDiscovered]
    [Tag("Crop Seed", 1)]                                 
    public partial class AmanitaMushroomSporesItem : SeedItem
    {
        static AmanitaMushroomSporesItem() { }
        
        private static Nutrients nutrition = new Nutrients() { Carbs = 0, Fat = 0, Protein = 0, Vitamins = 0 };

        public override LocString DisplayDescription { get { return Localizer.DoStr("Plant to grow amanita mushrooms. Not sure why you'd want these poisonous mushrooms, though."); } }
        public override LocString SpeciesName        { get { return Localizer.DoStr("AmanitaMushroom"); } }

        public override float Calories { get { return 0; } }
        public override Nutrients Nutrition { get { return nutrition; } }
    }


    [Serialized]
    [LocDisplayName("Amanita Mushroom Spores Pack")]
    [Category("Hidden")]
    [Weight(50)]  
    public partial class AmanitaMushroomSporesPackItem : SeedPackItem
    {
        static AmanitaMushroomSporesPackItem() { }

        public override LocString DisplayDescription { get { return Localizer.DoStr("Plant to grow amanita mushrooms. Not sure why you'd want these poisonous mushrooms, though."); } }
        public override LocString SpeciesName        { get { return Localizer.DoStr("AmanitaMushroom"); } }
    }

    [RequiresSkill(typeof(FarmingSkill), 1)]    
    public class AmanitaMushroomSporesRecipe : RecipeFamily
    {
        public AmanitaMushroomSporesRecipe()
        {
            this.Initialize(Localizer.DoStr("Amanita Mushroom Spores"), typeof(AmanitaMushroomSporesRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "AmanitaMushroomSpores",
                    Localizer.DoStr("Amanita Mushroom Spores"),
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(AmanitaMushroomsItem), 1, typeof(FarmingSkill), typeof(FarmingLavishResourcesTalent)),   
                    },
                new CraftingElement<AmanitaMushroomSporesItem>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(FarmingSkill), typeof(AmanitaMushroomSporesRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(AmanitaMushroomSporesRecipe), this.UILink(), 1, typeof(FarmingSkill), typeof(FarmingFocusedSpeedTalent), typeof(FarmingParallelSpeedTalent));    

            this.Initialize(Localizer.DoStr("Amanita Mushroom Spores"), typeof(AmanitaMushroomSporesRecipe));
            CraftingComponent.AddRecipe(typeof(FarmersTableObject), this);
        }
    }
}