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
    public partial class SteamTractorSowerRecipe :
        RecipeFamily
    {
        public SteamTractorSowerRecipe()
        {
            this.Initialize(Localizer.DoStr("Steam Tractor Sower"), typeof(SteamTractorSowerRecipe));
            this.Recipes = new List<Recipe>
            {
                new Recipe(
                    "SteamTractorSower",
                    Localizer.DoStr("Steam Tractor Sower"),
                    new IngredientElement[]
                    {
                    new IngredientElement(typeof(IronPlateItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)), 
                    new IngredientElement(typeof(ScrewsItem), 18, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)), 
                    new IngredientElement(typeof(IronPipeItem), 8, typeof(MechanicsSkill), typeof(MechanicsLavishResourcesTalent)),    
                    },
                    new CraftingElement[]
                    {
                    new CraftingElement<SteamTractorSowerItem>(), 
                    }
                )
            };


            this.ExperienceOnCraft = 10;  

            this.LaborInCalories = CreateLaborInCaloriesValue(200, typeof(MechanicsSkill), typeof(SteamTractorSowerRecipe), this.UILink()); 
            this.CraftMinutes = CreateCraftTimeValue(typeof(SteamTractorSowerRecipe), this.UILink(), 6, typeof(MechanicsSkill), typeof(MechanicsFocusedSpeedTalent), typeof(MechanicsParallelSpeedTalent));     
            this.Initialize(Localizer.DoStr("Steam Tractor Sower"), typeof(SteamTractorSowerRecipe));

            CraftingComponent.AddRecipe(typeof(AssemblyLineObject), this);
        }
    }

    [Serialized]
    [LocDisplayName("Steam Tractor Sower")]
    [Weight(10000)]      
    [Ecopedia("Items", "Tools", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    public partial class SteamTractorSowerItem :
    VehicleToolItem                        
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("An attachment for the steam tractor that allows for quick planting of seeds."); } }
    }
}