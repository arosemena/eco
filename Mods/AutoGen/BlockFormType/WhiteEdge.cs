﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    using System;
    using Eco.Gameplay.Blocks;
    using Eco.Shared.Localization;

    public partial class WhiteEdgeFormType : FormType
    {
        public override string Name => "WhiteEdge";
        public override LocString DisplayName => Localizer.DoStr("White Edge");
        public override LocString DisplayDescription => Localizer.DoStr("White Edge");
        public override Type GroupType => typeof(BasicFormGroup);
        public override int SortOrder => 80;
        public override int MinTier => 1;
    }
}
