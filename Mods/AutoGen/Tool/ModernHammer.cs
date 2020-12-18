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
    public partial class ModernHammerRecipe :
        RecipeFamily
    {
        public ModernHammerRecipe()
        {
            this.Initialize(Localizer.DoStr("Modern Hammer"), typeof(ModernHammerRecipe));            
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "ModernHammer",
                    new IngredientElement[]
                    {
               new IngredientElement(typeof(FiberglassItem), 10, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)), 
               new IngredientElement(typeof(SteelBarItem), 15, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),   
                    },
                new CraftingElement<ModernHammerItem>()
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(250, typeof(AdvancedSmeltingSkill), typeof(ModernHammerRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(ModernHammerRecipe), this.UILink(), 0.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));    
            this.Initialize(Localizer.DoStr("Modern Hammer"), typeof(ModernHammerRecipe));
            CraftingComponent.AddRecipe(typeof(AssemblyLineObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Modern Hammer")]
    [Tier(4)] 
    [Weight(1000)]
    [Category("Tool")]
    [Tag("Tool", 1)]
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                    
    public partial class ModernHammerItem : HammerItem
    {
        // Static values
        private static IDynamicValue caloriesBurn = new MultiDynamicValue(MultiDynamicOps.Multiply, new TalentModifiedValue(typeof(ModernHammerItem), typeof(ToolEfficiencyTalent)), CreateCalorieValue(10, typeof(SelfImprovementSkill), typeof(ModernHammerItem), new ModernHammerItem().UILink()));
        private static IDynamicValue tier = new ConstantValue(4);
        private static SkillModifiedValue skilledRepairCost = new SkillModifiedValue(15, AdvancedSmeltingSkill.MultiplicativeStrategy, typeof(AdvancedSmeltingSkill), Localizer.DoStr("repair cost"), DynamicValueType.Efficiency); 
        

        // Tool overrides

        public override IDynamicValue CaloriesBurn      => caloriesBurn;
        public override IDynamicValue Tier              => tier;
        public override IDynamicValue SkilledRepairCost => skilledRepairCost;
        public override float DurabilityRate            => DurabilityMax / 2500f;
        public override Item RepairItem                 => Item.Get<SteelBarItem>();
        public override int FullRepairAmount            => 15;
    }
}
