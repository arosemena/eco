﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Shared.Math;

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 2)]   
    [RepairRequiresSkill(typeof(AdvancedSmeltingSkill), 2)] 
    public partial class ModernHoeRecipe :
        RecipeFamily
    {
        public ModernHoeRecipe()
        {
            this.Initialize(Localizer.DoStr("Modern Hoe"), typeof(ModernHoeRecipe));            
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ModernHoe",
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(FiberglassItem), 10, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(SteelBarItem), 15, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),   
                    },
                new CraftingElement<ModernHoeItem>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(AdvancedSmeltingSkill), typeof(ModernHoeRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ModernHoeRecipe), this.UILink(), 0.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Modern Hoe"), typeof(ModernHoeRecipe));
            CraftingComponent.AddRecipe(typeof(AssemblyLineObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Modern Hoe")]
    [Tier(4)] 
    [Weight(1000)]
    [Category("Tool")]
    [Tag("Tool", 1)]
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                    
    public partial class ModernHoeItem : HoeItem
    {
        // Static values
        private static IDynamicValue caloriesBurn = CreateCalorieValue(10, typeof(FarmingSkill), typeof(ModernHoeItem), new ModernHoeItem().UILink());
        private static IDynamicValue exp = new ConstantValue(0.1f);
        private static IDynamicValue tier = new ConstantValue(4);
        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(15, AdvancedSmeltingSkill.MultiplicativeStrategy, typeof(AdvancedSmeltingSkill), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency); 
        
        private static Vector2i[] areaBlocks = new Vector2i[]
        {
        new Vector2i(0, 1), 
        new Vector2i(0, 2), 
        };

        // Tool overrides

        public override IDynamicValue CaloriesBurn      => caloriesBurn;
        public override Type ExperienceSkill            => typeof(FarmingSkill);
        public override IDynamicValue ExperienceRate    => exp;
        public override IDynamicValue Tier              => tier;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override float DurabilityRate            => DurabilityMax / 1500f;
        public override Item RepairItem                 => Item.Get<SteelBarItem>();
        public override int FullRepairAmount            => 15;
        public override Vector2i[] AreaBlocks           => areaBlocks;
    }
}
