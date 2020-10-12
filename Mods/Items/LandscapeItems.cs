﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System.ComponentModel;
    using Eco.Core.Items;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Pipes;
    using Eco.Gameplay.Wires;
    using Eco.Shared;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers;
    using Eco.World.Blocks;
    using World = Eco.World.World;

    [Serialized]
    [LocDisplayName("Dirt")]
    [Weight(30000)]
    [MaxStackSize(10)]
    [RequiresTool(typeof(ShovelItem))]
    [MakesRoads]
    [Ecopedia("Natural Resources", "Blocks", true, InPageTooltip.DynamicTooltip)]
    public class DirtItem : BlockItem<DirtBlock>, ICanExitFromPipe
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Dirt"); } }
        public override bool CanStickToWalls        { get { return false; } }

        public LocString FlowTooltip(float flowrate) => default;

        public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload)
        {
            var existingBlock = World.GetBlock(posDir.FirstPos) as EmptyBlock;
            if (existingBlock != null)
            {
                var target = World.FindPyramidPos(posDir.FirstPos);
                World.SetBlock(this.OriginType, target);
                return 1;
            }
            return 0;
        }
    }

    [Serialized]
    [LocDisplayName("Sand")]
    [Weight(30000)]
    [MaxStackSize(10)]
    [RequiresTool(typeof(ShovelItem))]
    [StartsDiscovered]
    [Ecopedia("Natural Resources", "Blocks", true, InPageTooltip.DynamicTooltip)]
    public class SandItem : BlockItem<SandBlock>
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Sand"); } }
        public override bool CanStickToWalls      { get { return false; } }
    }

    [RequiresTool(typeof(ShovelItem))]
    public partial class ClayItem : BlockItem<ClayBlock>
    {
    }

    [Serialized, Liquid]
    [LocDisplayName("Water")]
    [Category("Hidden")]
    [MaxStackSize(10)]
    [StartsDiscovered]
    [Tag("Liquid", 1)]
    [Ecopedia("Natural Resources", "Blocks", true, InPageTooltip.DynamicTooltip)]
    public class WaterItem : BlockItem<WaterBlock>, ICanExitFromPipe
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Water"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Water is an abundant resource. Fresh water can be found in rivers and lakes while salt water is found in the ocean. In addition to being a home to fish, water is needed for a variety of objects to function."); } }

        public override bool CanStickToWalls => false;
        public LocString FlowTooltip(float flowrate) => default;

        public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload)
        {
            var pos = posDir.FirstPos + Vector3i.Down;
            var existingBlock = World.GetBlock(pos);
            var waterOuput = Mathf.Min((payload.Amount / payload.Time) / 1000f, .999f);

            switch (existingBlock)
            {
                // Set the existing block if it's there, or add a new block.
                case EmptyBlock _:
                    World.SetBlock(typeof(WaterBlock), pos, waterOuput, true);
                    break;
                case WaterBlock waterBlock:
                    waterBlock.Water = waterOuput;
                    waterBlock.PipeSupplied = true;
                    break;
            }
            
            return payload.Amount;
        }
    }


    [Serialized, Liquid]
    [LocDisplayName("Sewage")]
    [Category("Hidden")]
    [StartsDiscovered]
    [Tag("Liquid", 1)]
    [Ecopedia("Blocks", "Byproducts", true, InPageTooltip.DynamicTooltip)]
    public class SewageItem : BlockItem<SewageBlock>, ICanExitFromPipe
    {
        public override LocString DisplayNamePlural { get { return Localizer.DoStr("Sewage"); } }
        public override LocString DisplayDescription { get { return Localizer.DoStr("Sewage is a byproduct that is often created when using water for industrial purposes. It is a source of ground pollution."); } }
        public override bool CanStickToWalls      { get { return false; } }
        public LocString FlowTooltip(float flowrate) => default;
        public const float SewageItemsPerPollution = 1000;

        public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload)
        {
            WorldLayerManager.ClimateSim.AddGroundPollution(posDir.FirstPos.XZ, payload.Amount / SewageItemsPerPollution / TimeUtil.SecondsPerHour);
            return payload.Amount;
        }
    }
}