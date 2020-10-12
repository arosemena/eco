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
    public partial class PetroleumRecipe :
        RecipeFamily
    {
        public PetroleumRecipe()
        {
            this.Initialize(Localizer.DoStr("Petroleum"), typeof(PetroleumRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Petroleum",
                    Localizer.DoStr("Petroleum"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(BarrelItem), 1, true),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<PetroleumItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(60, typeof(OilDrillingSkill), typeof(PetroleumRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = new MultiDynamicValue(MultiDynamicOps.Multiply
            , CreateCraftTimeValue(typeof(PetroleumRecipe), this.UILink(), 30, typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent))
            , new LayerModifiedValue(Eco.Simulation.WorldLayers.LayerNames.Oilfield,3)
            );
            this.Initialize(Localizer.DoStr("Petroleum"), typeof(PetroleumRecipe));

            CraftingComponent.AddRecipe(typeof(PumpJackObject), this);

        }
    }

    [Serialized]
    [Solid]
    [RequiresSkill(typeof(OilDrillingSkill), 1)]
    public partial class PetroleumBlock :
        PickupableBlock
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(PetroleumItem); } }
    }

    [Serialized]
    [LocDisplayName("Petroleum")]
    [MaxStackSize(10 * 2)]
    [Weight(10000)]
    [Ecopedia("Blocks", "Liquids", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    public partial class PetroleumItem :
    BlockItem<PetroleumBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Petroleum"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("A fossil fuel essential for manufacturing gasoline, plastics, and asphalt. It's extraction, transport, and burning all have environmental impacts."); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}
