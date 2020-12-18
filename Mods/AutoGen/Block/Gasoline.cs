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

    /// <summary>Auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.</summary>
    [RequiresSkill(typeof(OilDrillingSkill), 1)]
    public partial class GasolineRecipe :
        RecipeFamily
    {
        public GasolineRecipe()
        {
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "Gasoline",
                    Localizer.DoStr("Gasoline"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(PetroleumItem), 4, typeof(OilDrillingSkill), typeof(OilDrillingLavishResourcesTalent)),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<GasolineItem>(),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(OilDrillingSkill), typeof(GasolineRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(GasolineRecipe), this.UILink(), 0.8f, typeof(OilDrillingSkill), typeof(OilDrillingFocusedSpeedTalent), typeof(OilDrillingParallelSpeedTalent));
            this.ModsPreInitialize();
            this.Initialize(Localizer.DoStr("Gasoline"), typeof(GasolineRecipe));
            this.ModsPostInitialize();

            CraftingComponent.AddRecipe(typeof(OilRefineryObject), this);
        }

        /// <summary>Hook for mods to customize RecipeFamily before initialization. You can change recipes, xp, labor, time here.</summary>
        partial void ModsPreInitialize();
        /// <summary>Hook for mods to customize RecipeFamily after initialization, but before registration. You can change skill requirements here.</summary>
        partial void ModsPostInitialize();
    }

    [Serialized]
    [Solid]
    [RequiresSkill(typeof(OilDrillingSkill), 1)]
    public partial class GasolineBlock :
        PickupableBlock
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(GasolineItem); } }
    }

    [Serialized]
    [LocDisplayName("Gasoline")]
    [MaxStackSize(30)]
    [Weight(30000)]
    [Fuel(100000)][Tag("Fuel")]
    [Ecopedia("Blocks", "Liquids", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency][Tag("Currency")]
    [Tag("Liquid Fuel", 1)]
    public partial class GasolineItem :
    BlockItem<GasolineBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Gasoline"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Refined petroleum useful for fueling machines and generators."); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}
