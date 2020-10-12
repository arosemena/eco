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

    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class SteelPipeRecipe :
        RecipeFamily
    {
        public SteelPipeRecipe()
        {
            this.Initialize(Localizer.DoStr("Steel Pipe"), typeof(SteelPipeRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteelPipe",
                    Localizer.DoStr("Steel Pipe"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(SteelBarItem), 2, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteelPipeItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(AdvancedSmeltingSkill), typeof(SteelPipeRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteelPipeRecipe), this.UILink(), 1.5f, typeof(AdvancedSmeltingSkill), typeof(AdvancedSmeltingFocusedSpeedTalent), typeof(AdvancedSmeltingParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Steel Pipe"), typeof(SteelPipeRecipe));

            CraftingComponent.AddRecipe(typeof(BlastFurnaceObject), this);

        }
    }

    [Serialized]
    [Solid, Constructed]
    [BlockTier(3)]
    [DoesntEncase]
    [RequiresSkill(typeof(AdvancedSmeltingSkill), 1)]
    public partial class SteelPipeBlock :
        PipeBlock
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(SteelPipeItem); } }
    }

    [Serialized]
    [LocDisplayName("Steel Pipe")]
    [MaxStackSize(10 * 2)]
    [Weight(2000)]
    [Ecopedia("Blocks", "Pipes", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Constructable", 1)]
    [Tier(3)]
    public partial class SteelPipeItem :
    BlockItem<SteelPipeBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A pipe for transporting liquids."); } }

    }

}