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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class SteelBarRecipe :
        RecipeFamily
    {
        public SteelBarRecipe()
        {
            this.Initialize(Localizer.DoStr("Steel Bar"), typeof(SteelBarRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelBar",
                    Localizer.DoStr("Steel Bar"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    new IngredientElement(typeof(QuicklimeItem), 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    new IngredientElement("Coal", 1, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelBarItem>(),
                   new CraftingElement<SlagItem>(typeof(AdvancedSmeltingSkill), 2)

                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(AdvancedSmeltingSkill), typeof(SteelBarRecipe), this.UILink());
            this.ExperienceOnCraft = 2;
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelBarRecipe), this.UILink(), 1.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Steel Bar"), typeof(SteelBarRecipe));

            CraftingComponent.AddRecipe(typeof(BlastFurnaceObject), this);

        }
    }

    [Serialized]
    [Solid, Wall, Constructed]
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class SteelBarBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SteelBarItem); } }
    }

    [Serialized]
    [LocDisplayName("Steel Bar")]
    [MaxStackSize(20 * 2)]
    [Weight(30000)]
    [Ecopedia("Blocks", "Metals", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Metal", 1)]
    public partial class SteelBarItem :
    BlockItem<SteelBarBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Refined bar of steel."); } }

        public override bool CanStickToWalls { get { return false; } }

        private static Type[] blockTypes = new Type[] {
        typeof(SteelBarStacked1Block),
        typeof(SteelBarStacked2Block),
        typeof(SteelBarStacked3Block),
            typeof(SteelBarStacked4Block)
        };
        public override Type[] BlockTypes { get { return blockTypes; } }
    }

    [Serialized, Solid] public class SteelBarStacked1Block : PickupableBlock { }
    [Serialized, Solid] public class SteelBarStacked2Block : PickupableBlock { }
    [Serialized, Solid] public class SteelBarStacked3Block : PickupableBlock { }
    [Serialized, Solid,Wall] public class SteelBarStacked4Block : PickupableBlock { } //Only a wall if it's all 4 SteelBar
}