﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Mods.TechTree;
    using Eco.Shared.Items;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Shared.View;
    using Eco.Gameplay.Objects;
    using Eco.Gameplay.EcopediaRoot;

    [Serialized]
    [LocDisplayName("Tomato")]
    [Weight(10)]
    [Yield(typeof(TomatoItem), typeof(GatheringSkill), new float[] {1f, 1.4f, 1.5f, 1.6f, 1.7f, 1.8f, 1.9f, 2.0f})][Tag("Crop")]
    [Ecopedia("Food", "Produce", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
    [Crop]
    [Tag("Vegetable", 1)]
    [Tag("Raw Food", 1)]
    [Tag("Crop", 1)]
    public partial class TomatoItem : FoodItem
    {
        public override LocString DisplayDescription            { get { return Localizer.DoStr("Intelligence is knowing this is a fruit; wisdom is not putting it in a fruit salad."); } }

        private static Nutrients nutrition = new Nutrients()    { Carbs = 5, Fat = 0, Protein = 1, Vitamins = 2};
        public override float Calories                          { get { return 240; } }
        public override Nutrients Nutrition                     { get { return nutrition; } }
    }

}
