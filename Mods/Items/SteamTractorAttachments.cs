// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.TechTree
{
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.IoC;
    using Eco.Core.Utils;
    using Eco.Gameplay.Auth;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.Interactions;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Plants;
    using Eco.Shared.Math;
    using Eco.Simulation;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Stats;
    using Eco.Gameplay.GameActions;
    using Eco.Core.Items;
    using Eco.Gameplay.Aliases;
    using Eco.Shared.Items;

    [Tag("Plow")]
    [Category("Tool")]
    [Tag("Tool", 1)]
    public partial class SteamTractorPlowItem : VehicleToolItem
    {
        private static Vector3i[] area = new Vector3i[] { new Vector3i(0, 0, -2), new Vector3i(1, 0, -2), new Vector3i(-1, 0, -2) };
        public override void BlockInteraction(Vector3i pos, Quaternion rot, VehicleComponent vehicle, Inventory inv = null)
        {
            if (!this.enabled)
                return;

            foreach (var offset in area)
            {
                var targetPos = (rot.RotateVector(offset) + pos).XYZi;
                AtomicActions.TillSoilNow(targetPos, vehicle.Driver, this);
            }
        }
    }

    [Tag("Harvester")]
    [Category("Tool")]
    [Tag("Tool", 1)]
    public partial class SteamTractorHarvesterItem : VehicleToolItem
    {
        private static Vector3i[] area = new Vector3i[] { new Vector3i(0, 0, 3), new Vector3i(1, 0, 3), new Vector3i(-1, 0, 3) };
        public override void BlockInteraction(Vector3i pos, Quaternion rot, VehicleComponent vehicle, Inventory inv = null)
        {
            if (!this.enabled)
                return;

            foreach (var offset in area)
            {
                //Lawtodo: move this to be a performed action
                var targetPos = (rot.RotateVector(offset) + pos).XYZi;
                Result authResult = ServiceHolder<IAuthManager>.Obj.IsAuthorized(targetPos, vehicle.Driver.User, AccessType.ConsumerAccess, null);
                if (authResult.Success)
                {
                    var plant = PlantBlock.GetPlant(targetPos);
                    if (plant is PlantEntity harvestable)
                    {
                        if (plant.Alive)
                        {
                            var pack = new GameActionPack();
                            var changeSet = pack.GetOrCreateChangeSet(inv, vehicle.Driver.User);
                            harvestable.TryHarvest(vehicle.Driver, false, pack, changeSet, this);
                            pack.TryPerform();
                        }
                        else
                            World.DeleteBlock(targetPos);
                    }
                }
            }
        }
    }


    [Tag("Planter")]
    [Category("Tool")]
    [Tag("Tool", 1)]
    public partial class SteamTractorSowerItem : VehicleToolItem
    {
        private static Vector3i[] area = new Vector3i[] { new Vector3i(0, 0, 3), new Vector3i(1, 0, 3), new Vector3i(-1, 0, 3) };
        public override void BlockInteraction(Vector3i pos, Quaternion rot, VehicleComponent vehicle, Inventory inv = null)
        {
            if (inv == null)
                return;

            if (!this.enabled)
                return;

            foreach (var offset in area)
            {
                var stack = inv.GroupedStacks.Where(x => x.Item is SeedItem).FirstOrDefault();
                if (stack == null)
                    return;
                SeedItem seed = stack.Item as SeedItem;
                var targetPos = (rot.RotateVector(offset) + pos).XYZi;
                Result authResult = ServiceHolder<IAuthManager>.Obj.IsAuthorized(targetPos, vehicle.Driver.User, AccessType.ConsumerAccess, null);
                if (authResult.Success)
                {
                    if (World.GetBlock(targetPos + Vector3i.Down).Is<Tilled>() && World.GetBlock(targetPos).Is<Empty>())
                    {
                        var pack = new GameActionPack();
                        pack.AddGameAction(new PlantSeeds()
                        {
                            Species = seed.Species.GetType(),
                            Location = targetPos,
                            Citizen = vehicle.Driver.User,
                            ToolUsed = this
                        });

                        var changes = new InventoryChangeSet(inv, vehicle.Driver.User);
                        changes.RemoveItem(seed.Type);
                        pack.AddChangeSet(changes);

                        if (pack.TryPerform())
                        {
                            var plant = EcoSim.PlantSim.SpawnPlant(seed.Species, targetPos);
                            plant.Tended = true;
                        }
                    }
                }
            }
        }
    }
}
