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

    [RequiresSkill(typeof(MiningSkill), 1)]
    public partial class GoldConcentrateRecipe :
        RecipeFamily
    {
        public GoldConcentrateRecipe()
        {
            this.Initialize(Localizer.DoStr("Gold Concentrate"), typeof(GoldConcentrateRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "GoldConcentrate",
                    Localizer.DoStr("Gold Concentrate"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(CrushedGoldOreItem), 10, typeof(MiningSkill)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<GoldConcentrateItem>(),
                   new CraftingElement<WetTailingsItem>(typeof(MiningSkill), 4)

                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(40, typeof(MiningSkill), typeof(GoldConcentrateRecipe), this.UILink());
            this.ExperienceOnCraft = 2;
            this.CraftMinutes = CreateCraftTimeValue(typeof(GoldConcentrateRecipe), this.UILink(), 1.5f, typeof(MiningSkill));
            this.Initialize(Localizer.DoStr("Gold Concentrate"), typeof(GoldConcentrateRecipe));

            CraftingComponent.AddRecipe(typeof(RockerBoxObject), this);

        }
    }

    [Serialized]
    [Solid, Wall, Diggable]
    [RequiresSkill(typeof(MiningSkill), 1)]
    public partial class GoldConcentrateBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GoldConcentrateItem); } }
    }

    [Serialized]
    [LocDisplayName("Gold Concentrate")]
    [MaxStackSize(10 * 2)]
    [Weight(22000)]
    [Ecopedia("Blocks", "Processed Rock", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("ConcentratedOre", 1)]
    [RequiresTool(typeof(ShovelItem))]
    public partial class GoldConcentrateItem :
    BlockItem<GoldConcentrateBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Gold Concentrate"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Gold ore that has been concentrated to remove impurities. Ore concentrate is used by smiths to smelt metal bars."); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}