﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class RoofPeakFormType : FormType
    {
        public override string Name => "RoofPeak";
        public override LocString DisplayName => Localizer.DoStr("RoofPeak");
        public override LocString DisplayDescription => Localizer.DoStr("Roof Peak");
        public override Type GroupType => typeof(RoofsFormGroup);
        public override int SortOrder => 56;
        public override int MinTier => 1;
    }
}