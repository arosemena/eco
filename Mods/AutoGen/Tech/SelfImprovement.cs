﻿// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.
// <auto-generated />

namespace Eco.Mods.TechTree
{
        using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using Eco.Core.Items;
    using Eco.Core.Utils;
    using Eco.Core.Utils.AtomicAction;
    using Eco.Gameplay.Blocks;
    using Eco.Gameplay.Components;
    using Eco.Gameplay.DynamicValues;
    using Eco.Gameplay.Items;
    using Eco.Gameplay.Players;
    using Eco.Gameplay.Property;
    using Eco.Gameplay.Skills;
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Services;
    using Eco.Shared.Utils;
    using Gameplay.Systems.Tooltip;

    [Serialized]
    [LocDisplayName("Self Improvement")]
    [Ecopedia("Professions", "Survivalist", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]    
    [RequiresSkill(typeof(SurvivalistSkill), 0), Tag("Survivalist Specialty"), Tier(1)]    
    public partial class SelfImprovementSkill : Skill
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("Self-improvement increases both the amount of weight citizens can carry and their stomach capacity. It also decreases the calories expended when using hammers and shovels.  Experience is gained when leveling up other specialties."); } }



        public static MultiplicativeStrategy MultiplicativeStrategy =
            new MultiplicativeStrategy(new float[] { 1,
                
                1 - 0.05f,
                
                1 - 0.1f,
                
                1 - 0.15f,
                
                1 - 0.2f,
                
                1 - 0.25f,
                
                1 - 0.25f,
                
                1 - 0.25f,
                
            });
        public override MultiplicativeStrategy MultiStrategy => MultiplicativeStrategy;
        public static AdditiveStrategy AdditiveStrategy =
            new AdditiveStrategy(new float[] { 0,
                
                0,
                
                250,
                
                500,
                
                1000,
                
                1500,
                
                2000,
                
                2500,
                
            });
        public override AdditiveStrategy AddStrategy => AdditiveStrategy;
        public static int[] SkillPointCost = {
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
            1,
            
        };
        public override int RequiredPoint { get { return this.Level < SkillPointCost.Length ? SkillPointCost[this.Level] : 0; } }
        public override int PrevRequiredPoint { get { return this.Level - 1 >= 0 && this.Level - 1 < SkillPointCost.Length ? SkillPointCost[this.Level - 1] : 0; } }
        public override int MaxLevel { get { return 7; } }
        public override int Tier { get { return 1; } }
    }

}