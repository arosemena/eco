// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using Eco.Gameplay.Items;

    public partial class IronPipeItem : BlockItem<IronPipeBlock>
    {
        public override bool DisplayCrate { get { return true; } }
    }
    public partial class SteelPipeItem : BlockItem<SteelPipeBlock>
    {
        public override bool DisplayCrate { get { return true; } }
    }
    public partial class CopperPipeItem : BlockItem<CopperPipeBlock>
    {
        public override bool DisplayCrate { get { return true; } }
    }
}