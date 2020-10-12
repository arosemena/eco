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

    [RequiresSkill(typeof(CompositesSkill), 1)]
    public partial class CompositeFirLumberRecipe :
        Recipe
    {
        public CompositeFirLumberRecipe()
        {
            var product = new Recipe(
                "CompositeFirLumber",
                Localizer.DoStr("Composite Fir Lumber"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(FirLogItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement(typeof(PlasticItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement(typeof(EpoxyItem), 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                    new IngredientElement("Lumber", 1, typeof(CompositesSkill), typeof(CompositesLavishResourcesTalent)),
                },

				new CraftingElement[]
                {
                    new CraftingElement<CompositeFirLumberItem>()
				});
            CraftingComponent.AddTagProduct(typeof(AdvancedCarpentryTableObject), typeof(CompositeLumberRecipe), product);

        }
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [BlockTier(4)]
    [RequiresSkill(typeof(CompositesSkill), 1)]
    public partial class CompositeFirLumberBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CompositeFirLumberItem); } }
    }

    [Serialized]
    [LocDisplayName("Composite Fir Lumber")]
    [MaxStackSize(20 * 2)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Building Materials", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("CompositeLumber", 1)]
    [Tag("SoftwoodLumber", 1)]
    [Tag("Constructable", 1)]
    [Tier(4)]
    public partial class CompositeFirLumberItem :
    BlockItem<CompositeFirLumberBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Composite Fir Lumber"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("A composite lumber made from a combination of wood and plastic."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(CompositeFirLumberStacked1Block),
        typeof(CompositeFirLumberStacked2Block),
        typeof(CompositeFirLumberStacked3Block),
            typeof(CompositeFirLumberStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class CompositeFirLumberStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class CompositeFirLumberStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class CompositeFirLumberStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class CompositeFirLumberStacked4Block : PickupableBlock { } //Only a wall if it's all 4 CompositeFirLumber
}