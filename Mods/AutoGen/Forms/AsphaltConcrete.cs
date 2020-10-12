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
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;
    


    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(CubeFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AsphaltConcreteItem); } }
    }


    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteCubeFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteCubeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AsphaltConcreteItem); } }
    }


    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteLineFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteLineBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AsphaltConcreteItem); } }
    }


    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteDashLineFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteDashLineBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AsphaltConcreteItem); } }
    }


    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteEdgeFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteEdgeBlock :
        Block, IRepresentsItem
    {
        public Type RepresentedItemType { get { return typeof(AsphaltConcreteItem); } }
    }



    [RotatedVariants(typeof(AsphaltConcreteWhiteRampLineABlock), typeof(AsphaltConcreteWhiteRampLineA90Block), typeof(AsphaltConcreteWhiteRampLineA180Block), typeof(AsphaltConcreteWhiteRampLineA270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampLineAFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampLineABlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineA90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineA180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineA270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampLineBBlock), typeof(AsphaltConcreteWhiteRampLineB90Block), typeof(AsphaltConcreteWhiteRampLineB180Block), typeof(AsphaltConcreteWhiteRampLineB270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampLineBFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampLineBBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineB90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineB180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineB270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampLineCBlock), typeof(AsphaltConcreteWhiteRampLineC90Block), typeof(AsphaltConcreteWhiteRampLineC180Block), typeof(AsphaltConcreteWhiteRampLineC270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampLineCFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampLineCBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineC90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineC180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineC270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampLineDBlock), typeof(AsphaltConcreteWhiteRampLineD90Block), typeof(AsphaltConcreteWhiteRampLineD180Block), typeof(AsphaltConcreteWhiteRampLineD270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampLineDFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampLineDBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineD90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineD180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampLineD270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampDashLineABlock), typeof(AsphaltConcreteWhiteRampDashLineA90Block), typeof(AsphaltConcreteWhiteRampDashLineA180Block), typeof(AsphaltConcreteWhiteRampDashLineA270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampDashLineAFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampDashLineABlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineA90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineA180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineA270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampDashLineBBlock), typeof(AsphaltConcreteWhiteRampDashLineB90Block), typeof(AsphaltConcreteWhiteRampDashLineB180Block), typeof(AsphaltConcreteWhiteRampDashLineB270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampDashLineBFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampDashLineBBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineB90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineB180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineB270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampDashLineCBlock), typeof(AsphaltConcreteWhiteRampDashLineC90Block), typeof(AsphaltConcreteWhiteRampDashLineC180Block), typeof(AsphaltConcreteWhiteRampDashLineC270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampDashLineCFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampDashLineCBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineC90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineC180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineC270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampDashLineDBlock), typeof(AsphaltConcreteWhiteRampDashLineD90Block), typeof(AsphaltConcreteWhiteRampDashLineD180Block), typeof(AsphaltConcreteWhiteRampDashLineD270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampDashLineDFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampDashLineDBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineD90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineD180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampDashLineD270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteRampABlock), typeof(AsphaltConcreteRampA90Block), typeof(AsphaltConcreteRampA180Block), typeof(AsphaltConcreteRampA270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(RampAFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteRampABlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampA90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampA180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampA270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteRampBBlock), typeof(AsphaltConcreteRampB90Block), typeof(AsphaltConcreteRampB180Block), typeof(AsphaltConcreteRampB270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(RampBFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteRampBBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampB90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampB180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampB270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteRampCBlock), typeof(AsphaltConcreteRampC90Block), typeof(AsphaltConcreteRampC180Block), typeof(AsphaltConcreteRampC270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(RampCFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteRampCBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampC90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampC180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampC270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteRampDBlock), typeof(AsphaltConcreteRampD90Block), typeof(AsphaltConcreteRampD180Block), typeof(AsphaltConcreteRampD270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(RampDFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteRampDBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampD90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampD180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteRampD270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampEdgeABlock), typeof(AsphaltConcreteWhiteRampEdgeA90Block), typeof(AsphaltConcreteWhiteRampEdgeA180Block), typeof(AsphaltConcreteWhiteRampEdgeA270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampEdgeAFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampEdgeABlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeA90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeA180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeA270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampEdgeBBlock), typeof(AsphaltConcreteWhiteRampEdgeB90Block), typeof(AsphaltConcreteWhiteRampEdgeB180Block), typeof(AsphaltConcreteWhiteRampEdgeB270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampEdgeBFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampEdgeBBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeB90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeB180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeB270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampEdgeCBlock), typeof(AsphaltConcreteWhiteRampEdgeC90Block), typeof(AsphaltConcreteWhiteRampEdgeC180Block), typeof(AsphaltConcreteWhiteRampEdgeC270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampEdgeCFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampEdgeCBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeC90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeC180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeC270Block : Block
    { }


    [RotatedVariants(typeof(AsphaltConcreteWhiteRampEdgeDBlock), typeof(AsphaltConcreteWhiteRampEdgeD90Block), typeof(AsphaltConcreteWhiteRampEdgeD180Block), typeof(AsphaltConcreteWhiteRampEdgeD270Block))]
    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    [IsForm(typeof(WhiteRampEdgeDFormType), typeof(AsphaltConcreteItem))]
    public partial class AsphaltConcreteWhiteRampEdgeDBlock : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeD90Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeD180Block : Block
    { }

    [Serialized]
    [MakesRoads] 
    [Road(1.4f)] 
    [Wall, Constructed, Solid] 
    public partial class AsphaltConcreteWhiteRampEdgeD270Block : Block
    { }

}
