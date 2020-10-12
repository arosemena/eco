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
    public partial class CrushedGraniteRecipe :
        RecipeFamily
    {
        public CrushedGraniteRecipe()
        {
            this.Initialize(Localizer.DoStr("Crushed Granite"), typeof(CrushedGraniteRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "CrushedGranite",
                    Localizer.DoStr("Crushed Granite"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(GraniteItem), 12, true),
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<CrushedGraniteItem>(3),
                    }
                )
            };
            this.LaborInCalories = CreateLaborInCaloriesValue(100, typeof(MiningSkill), typeof(CrushedGraniteRecipe), this.UILink());
            this.ExperienceOnCraft = 0.5f;
            this.CraftMinutes = CreateCraftTimeValue(typeof(CrushedGraniteRecipe), this.UILink(), 1.5f, typeof(MiningSkill));
            this.Initialize(Localizer.DoStr("Crushed Granite"), typeof(CrushedGraniteRecipe));

            CraftingComponent.AddRecipe(typeof(ArrastraObject), this);

        }
    }

    [Serialized]
    [Solid, Wall, Diggable]
    [RequiresSkill(typeof(MiningSkill), 1)]
    public partial class CrushedGraniteBlock :
        Block
        , IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(CrushedGraniteItem); } }
    }

    [Serialized]
    [LocDisplayName("Crushed Granite")]
    [MaxStackSize(20)]
    [Weight(30000)]
    [StartsDiscovered]
    [Ecopedia("Blocks", "Processed Rock", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Currency]
    [Tag("CrushedRock", 1)]
    [Tag("Silica", 1)]
    [RequiresTool(typeof(ShovelItem))]
    public partial class CrushedGraniteItem :
    BlockItem<CrushedGraniteBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Crushed Granite"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Granite rocks that have been crushed into a fine gravel."); } }

        public override bool CanStickToWalls { get { return false; } }
    }

}
