﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Core.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    using Eco.Gameplay.Pipes.LiquidComponents;

    [RequiresSkill(typeof(OilDrillingSkill), 1)]
    public partial class BarrelRecipe :
        RecipeFamily
    {
        public BarrelRecipe()
        {
            this.Initialize(Localizer.DoStr("Barrel"), typeof(BarrelRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Barrel",
                    Localizer.DoStr("Barrel"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronBarItem), 1, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<BarrelItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(180, typeof(OilDrillingSkill), typeof(BarrelRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(BarrelRecipe), this.UILink(), 0.5f, typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Barrel"), typeof(BarrelRecipe));

            CraftingComponent.AddRecipe(typeof(ElectricMachinistTableObject), this);

        }
    }

    [Serialized]
    [Solid]
    [RequiresSkill(typeof(OilDrillingSkill), 1)]
    public partial class BarrelBlock :
        PickupableBlock
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(BarrelItem); } }
    }

    [Serialized]
    [LocDisplayName("Barrel")]
    [MaxStackSize(10 * 2)]
    [Weight(2000)]
    [Ecopedia("Blocks", "Liquids", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    public partial class BarrelItem :
    BlockItem<BarrelBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A metal barrel for carrying liquids."); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}