﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class WindowT2FormType : FormType
    {
        public override string Name => "WindowT2";
        public override LocString DisplayName => Localizer.DoStr("WindowT2");
        public override LocString DisplayDescription => Localizer.DoStr("WindowT2");
        public override Type GroupType => typeof(ThinFormGroup);
        public override int SortOrder => 15;
        public override int MinTier => 1;
    }
}