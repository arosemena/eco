﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
    }
// WORLD LAYER INFO
namespace Eco.Mods.WorldLayers
{
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Utils;
    using Eco.Simulation.WorldLayers.Layers;

    public partial class PlantLayerSettingsLupine : PlantLayerSettings
    {
        public PlantLayerSettingsLupine() : base()
        {
            this.Name = "Lupine";
            this.DisplayName = string.Format("{0} {1}", Localizer.DoStr("Lupine"), Localizer.DoStr("Population"));
            this.InitMultiplier = 1;
            this.SyncToClient = false;
            this.Range = new Range(0f, 1f);
            this.RenderRange = new Range(0f, 0.333333f);
            this.MinColor = new Color(1f, 1f, 1f);
            this.MaxColor = new Color(0f, 1f, 0f);
            this.SumRelevant = true;
            this.Unit = "Lupine";
            this.VoxelsPerEntry = 5;
            this.Category = WorldLayerCategory.Plant;
            this.ValueType = WorldLayerValueType.FillRate;
            this.AreaDescription = "";
        }
    }
}

namespace Eco.Mods.Organisms
{
    using System.Collections.Generic;
    using Eco.Core.Items;
    using Eco.Gameplay.Plants;
    using Eco.Mods.TechTree;
    using Eco.Shared.Localization;
    using Eco.Shared.Math;
    using Eco.Shared.Serialization;
    using Eco.Simulation;
    using Eco.Simulation.Types;
    using Eco.World.Blocks;

    [Serialized]
    public partial class Lupine : PlantEntity
    {
        public Lupine(WorldPosition3i mapPos, PlantPack plantPack) : base(species, mapPos, plantPack) { }
        public Lupine() { }
        static PlantSpecies species;

        [Ecopedia("Plants", "Plants", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]
        public partial class LupineSpecies : PlantSpecies
        {
            public LupineSpecies() : base()
            {
                species = this;
                this.InstanceType = typeof(Lupine);

                // Info
                this.Decorative = false;
                this.Name = "Lupine";
                this.DisplayName = Localizer.DoStr("Lupine");
                // Lifetime
                this.MaturityAgeDays = 0.8f;
                // Generation
                this.Height = 1;
                // Food
                this.CalorieValue = 2;
                // Resources
                this.PostHarvestingGrowth = 0;
                this.PickableAtPercent = 0;
                this.ResourceList = new List<SpeciesResource>()
                {
                    new SpeciesResource(typeof(PlantFibersItem), new Range(1, 2), 1)
                };
                this.ResourceBonusAtGrowth = 0.9f;
                // Visuals
                this.BlockType = typeof(LupineBlock);
                // Climate
                this.ReleasesCO2TonsPerDay = -0.0002f;
                // WorldLayers
                this.MaxGrowthRate = 0.01f;
                this.MaxDeathRate = 0.005f;
                this.SpreadRate = 0.001f;
                this.ResourceConstraints.Add(new ResourceConstraint() { LayerName = "SoilMoisture", HalfSpeedConcentration =  0.0f, MaxResourceContent =  1.0f }); 
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "FertileGround", ConsumedCapacityPerPop =  1 });
                this.CapacityConstraints.Add(new CapacityConstraint() { CapacityLayerName = "ShrubSpace", ConsumedCapacityPerPop =  3 }); 
                this.GenerationSpawnCountPerPoint = new Range(15, 20); 
                this.GenerationSpawnPointMultiplier = 0.15f; 
                this.BlanketSpawnPercent = 0.05f; 
                this.IdealTemperatureRange = new Range(0.24f, 0.28f);
                this.IdealMoistureRange = new Range(0.44f, 0.48f);
                this.IdealWaterRange = new Range(0, 0.1f);
                this.WaterExtremes = new Range(0, 0.2f);
                this.TemperatureExtremes = new Range(0.2f, 0.3f);
                this.MoistureExtremes = new Range(0.2f, 0.5f);
                this.MaxPollutionDensity = 0.7f;
                this.PollutionDensityTolerance = 0.1f;
                this.VoxelsPerEntry = 5;

            }
        }
    }
    [Serialized]
    [Reapable] 
    [Clearable]
    [MoveEfficiency(0.8f)] 
    public partial class LupineBlock :
        PlantBlock { } 
}
