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

    [RequiresSkill(typeof(SmeltingSkill), 1)]
    public partial class IronPipeRecipe :
        RecipeFamily
    {
        public IronPipeRecipe()
        {
            this.Initialize(Localizer.DoStr("Iron Pipe"), typeof(IronPipeRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "IronPipe",
                    Localizer.DoStr("Iron Pipe"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronBarItem), 2, typeof(SmeltingSkill), typeof(SmeltingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<IronPipeItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(20, typeof(SmeltingSkill), typeof(IronPipeRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(IronPipeRecipe), this.UILink(), 0.8f, typeof(SmeltingSkill), typeof(SmeltingFocusedSpeedTalent), typeof(SmeltingParallelSpeedTalent));
            this.Initialize(Localizer.DoStr("Iron Pipe"), typeof(IronPipeRecipe));

            CraftingComponent.AddRecipe(typeof(AnvilObject), this);

        }
    }

    [Serialized]
    [Solid, Constructed]
    [BlockTier(2)]
    [DoesntEncase]
    [RequiresSkill(typeof(SmeltingSkill), 1)]
    public partial class IronPipeBlock :
        PipeBlock
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(IronPipeItem); } }
    }

    [Serialized]
    [LocDisplayName("Iron Pipe")]
    [MaxStackSize(10 * 2)]
    [Weight(2000)]
    [Ecopedia("Blocks", "Pipes", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("Constructable", 1)]
    [Tier(2)]
    public partial class IronPipeItem :
    BlockItem<IronPipeBlock>
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A pipe for transporting liquids."); } }

    }

}