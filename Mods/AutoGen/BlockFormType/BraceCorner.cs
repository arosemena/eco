﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class BraceCornerFormType : FormType
    {
        public override string Name => "BraceCorner";
        public override LocString DisplayName => Localizer.DoStr("BraceCorner");
        public override LocString DisplayDescription => Localizer.DoStr("Brace Corner");
        public override Type GroupType => typeof(SupportsFormGroup);
        public override int SortOrder => 46;
        public override int MinTier => 1;
    }
}
