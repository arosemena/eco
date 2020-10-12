﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class WallTrimFormType : FormType
    {
        public override string Name => "WallTrim";
        public override LocString DisplayName => Localizer.DoStr("WallTrim");
        public override LocString DisplayDescription => Localizer.DoStr("Wall Trim");
        public override Type GroupType => typeof(ThinFormGroup);
        public override int SortOrder => 14;
        public override int MinTier => 1;
    }
}
