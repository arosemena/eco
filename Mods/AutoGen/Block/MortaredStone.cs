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

    [RequiresSkill(typeof(MasonrySkill), 1)]
    public partial class MortaredStoneRecipe :
        RecipeFamily
    {
        public MortaredStoneRecipe()
        {
            this.Initialize(Localizer.DoStr("Mortared Stone"), typeof(MortaredStoneRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "MortaredStone",
                    Localizer.DoStr("Mortared Stone"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(MortarItem), 1, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),
                    new IngredientElement("Rock", 4, typeof(MasonrySkill), typeof(MasonryLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<MortaredStoneItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(30, typeof(MasonrySkill), typeof(MortaredStoneRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(MortaredStoneRecipe), this.UILink(), 0.15f, typeof(MasonrySkill), typeof(MasonryFocusedSpeedTalent), typeof(MasonryParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Mortared Stone"), typeof(MortaredStoneRecipe));

            CraftingComponent.AddRecipe(typeof(MasonryTableObject), this);

        }
    }

    [Serialized]
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    [BlockTier(1)]
    [RequiresSkill(typeof(MasonrySkill), 1)]
    public partial class MortaredStoneBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(MortaredStoneItem); } }
    }

    [Serialized]
    [LocDisplayName("Mortared Stone")]
    [MaxStackSize(15 * 2)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("MortaredStone", 1)]
    [Tag("Constructable", 1)]
    [Tier(1)]
    public partial class MortaredStoneItem :
    BlockItem<MortaredStoneBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Old stone"); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(MortaredStoneStacked1Block),
        typeof(MortaredStoneStacked2Block),
            typeof(MortaredStoneStacked3Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class MortaredStoneStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class MortaredStoneStacked2Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class MortaredStoneStacked3Block : PickupableBlock { } //Only a wall if it's all 4 MortaredStone
}