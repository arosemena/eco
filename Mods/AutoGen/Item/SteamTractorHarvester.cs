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
    using Eco.Gameplay.Systems;
    using Eco.Gameplay.Systems.TextLinks;
    using Eco.Shared.Localization;
    using Eco.Shared.Serialization;
    using Eco.Shared.Utils;
    using Eco.Core.Items;
    using Eco.World;
    using Eco.World.Blocks;
    using Eco.Gameplay.Pipes;

    [RequiresSkill(typeof(MechanicsSkill), 1)]      
    public partial class SteamTractorHarvesterRecipe :
        RecipeFamily
    {
        public SteamTractorHarvesterRecipe()
        {
            this.Initialize(Localizer.DoStr("Steam Tractor Harvester"), typeof(SteamTractorHarvesterRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteamTractorHarvester",
                    Localizer.DoStr("Steam Tractor Harvester"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronPlateItem), 12, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)), 
                    new IngredientElement(typeof(ScrewsItem), 12, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)), 
                    new IngredientElement(typeof(IronPipeItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteamTractorHarvesterItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 10;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(MechanicsSkill), typeof(SteamTractorHarvesterRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteamTractorHarvesterRecipe), this.UILink(), 6, typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Steam Tractor Harvester"), typeof(SteamTractorHarvesterRecipe));

            CraftingComponent.AddRecipe(typeof(AssemblyLineObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Steam Tractor Harvester")]
    [Weight(10000)]      
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SteamTractorHarvesterItem :
    VehicleToolItem                        
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("An attachment for the steam tractor that allows for quick harvesting of plants."); } }
    }
}