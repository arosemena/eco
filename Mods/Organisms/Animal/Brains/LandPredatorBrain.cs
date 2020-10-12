// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Eco.Mods.Organisms
{
    using Eco.Shared.States;
    using Eco.Simulation.Agents;
    using Eco.Simulation.Agents.AI;
    using Eco.Gameplay.AI;
    using Eco.Mods.Organisms.Behaviors;

    public class LandPredatorBrain : LandAnimalBrain 
    {
        public static readonly Behavior<Animal> FindAndAttackEnemyTree;
        public static readonly Behavior<Animal> LandPredatorTreeRoot;

        public override Behavior<Animal> RootBehavior(Animal animal) => LandPredatorTreeRoot;

        static LandPredatorBrain()
        {
            FindAndAttackEnemyTree =
                BT.Selector("Select Attacking",
                    BT.If("Looking for an enemy", PredatorBehaviors.FindEnemy,
                        BT.If("Ready For Attack", PredatorBehaviors.CheckAttacking,
                            BT.Selector("Attack Enemy",
                                BT.If("Try Wake Up", x => ((x.State == AnimalState.Sleeping || x.State == AnimalState.LyingDown) &&
                                                           x.Alertness < Animal.WakeUpAlertness, "sleeping/lying and alert"),
                                    Anim(AnimalState.Idle, true, x => x.Species.TimeLayToStand)),
                                BT.If("Try Make Route", PredatorBehaviors.ChasePrey)
                            )
                        )
                    )
                );


            LandPredatorTreeRoot =
                BT.Selector("Land Predator Brain",
                    MovementBehaviors.Flee,
                    FindAndAttackEnemyTree,
                    FindAndEatCorpse,
                    LyingDownTree,
                    MovementBehaviors.TryReturnHome,
                    RelaxBehaviors.Relax,
                    MovementBehaviors.Wander,
                    RelaxBehaviors.Idle
                );
        }
        
        public static Behavior<Animal> FindAndEatCorpse = new FindAndEatCorpseBehavior(new LandAnimalFindFoodBehavior());
    }
}
