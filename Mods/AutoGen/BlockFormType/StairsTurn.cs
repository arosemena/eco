﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class StairsTurnFormType : FormType
    {
        public override string Name => "StairsTurn";
        public override LocString DisplayName => Localizer.DoStr("StairsTurn");
        public override LocString DisplayDescription => Localizer.DoStr("Stairs Turn");
        public override Type GroupType => typeof(ClimbingFormGroup);
        public override int SortOrder => 44;
        public override int MinTier => 1;
    }
}