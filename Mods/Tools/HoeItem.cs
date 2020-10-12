// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
#nullable enable
using System;
using System.ComponentModel;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Interactions;
using Eco.Gameplay.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.World;
using Eco.World.Blocks;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Gameplay.GameActions;
using Eco.Shared.Items;
using Eco.Simulation;
using Eco.Gameplay.Objects;
using Eco.Core.Items;

[Serialized]
[LocDisplayName("Hoe")]
[Category("Hidden")]
[Hoer, Tag("Plow")]
public class HoeItem : ToolItem, IPerformsToolAction
{
    public ToolInteractAction MakeAction(ToolActionType tool) => new PlowField();
    private static IDynamicValue skilledRepairCost = new ConstantValue(1);
    static IDynamicValue caloriesBurn = new ConstantValue(1);
    static IDynamicValue tier = new ConstantValue(0);

    public override LocString DisplayDescription { get { return Localizer.DoStr("Used to till soil and prepare it for planting."); } }


    public override ClientPredictedBlockAction LeftAction { get { return ClientPredictedBlockAction.None; } }
    public override LocString LeftActionDescription { get { return Localizer.DoStr("Hoe ground"); } }

    public override IDynamicValue SkilledRepairCost { get { return skilledRepairCost; } }

    public override Item RepairItem { get { return Item.Get<StoneItem>(); } }
    public override int FullRepairAmount { get { return 1; } }
    public override IDynamicValue CaloriesBurn { get { return caloriesBurn; } }
    public override IDynamicValue Tier { get { return tier; } }
    public override Type ExperienceSkill => typeof(FarmingSkill);

    public override InteractResult OnActLeft(InteractionContext context)
    {
        if (context.HasBlock)
        {
            var pack = new GameActionPack();
            pack.PrepareMultiblockToolAction(this, context, (blockPos, actionPack) =>
            {
                return AtomicActions.TillSoilNow(blockPos.Pos + Vector3i.Up, context.Player, this);
            }, null, Localizer.DoStr("farming"));

            return (InteractResult)pack.TryPerform(false);
        }

        if (context.Target is WorldObject) return this.BasicToolOnWorldObjectCheck(context);

        return base.OnActLeft(context);
    }

    public override bool ShouldHighlight(Type block) => Block.Is<Tillable>(block);
}
