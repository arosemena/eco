﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class ThinColumnFormType : FormType
    {
        public override string Name => "ThinColumn";
        public override LocString DisplayName => Localizer.DoStr("Thin Column");
        public override LocString DisplayDescription => Localizer.DoStr("Thin Column");
        public override Type GroupType => typeof(SupportsFormGroup);
        public override int SortOrder => 28;
        public override int MinTier => 1;
    }
}
