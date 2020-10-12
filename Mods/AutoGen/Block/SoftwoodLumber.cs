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

    [RequiresSkill(typeof(CarpentrySkill), 2)]
    public partial class SoftwoodLumberRecipe :
        RecipeFamily
    {
        public SoftwoodLumberRecipe()
        {
            this.Initialize(Localizer.DoStr("Softwood Lumber"), typeof(SoftwoodLumberRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SoftwoodLumber",
                    Localizer.DoStr("Softwood Lumber"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SoftwoodHewnLogItem), 4, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    new IngredientElement(typeof(NailItem), 4, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SoftwoodLumberItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(CarpentrySkill), typeof(SoftwoodLumberRecipe), this.UILink());
            this.ExperienceOnCraft = 1;
            this.CraftMinutes = CreateCraftTimeValue(typeof(SoftwoodLumberRecipe), this.UILink(), 0.5f, typeof(CarpentrySkill), typeof(CarpentryFocusedSpeedTalent), typeof(CarpentryParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Softwood Lumber"), typeof(SoftwoodLumberRecipe));

            CraftingComponent.AddRecipe(typeof(SawmillObject), this);

        }
    }

    [Serialized]
    [Solid, Wall, Constructed,BuildRoomMaterialOption]
    [BlockTier(2)]
    [RequiresSkill(typeof(CarpentrySkill), 2)]
    public partial class SoftwoodLumberBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SoftwoodLumberItem); } }
    }

    [Serialized]
    [LocDisplayName("Softwood Lumber")]
    [MaxStackSize(20 * 2)]
    [Weight(10000)]
    [Fuel(4000)][Tag("Fuel")]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Lumber", 1)]
    [Tag("Burnable Fuel", 1)]
    [Tag("Constructable", 1)]
    [Tier(2)]
    public partial class SoftwoodLumberItem :
    BlockItem<SoftwoodLumberBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Softwood Lumber"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Can be fashioned into various usable equipment."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(SoftwoodLumberStacked1Block),
        typeof(SoftwoodLumberStacked2Block),
        typeof(SoftwoodLumberStacked3Block),
            typeof(SoftwoodLumberStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class SoftwoodLumberStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class SoftwoodLumberStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class SoftwoodLumberStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class SoftwoodLumberStacked4Block : PickupableBlock { } //Only a wall if it's all 4 SoftwoodLumber
}