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

    [RequiresSkill(typeof(CarpentrySkill), 1)]      
    public partial class HardwoodBoardRecipe :
        Recipe
    {
        public HardwoodBoardRecipe()
        {
            var product = new Recipe(
                "HardwoodBoard",
                Localizer.DoStr("Hardwood Board"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(HardwoodHewnLogItem), 1, typeof(CarpentrySkill), typeof(CarpentryLavishResourcesTalent)),    
                }, 
                    new CraftingElement<HardwoodBoardItem>() 
            );
            CraftingComponent.AddTagProduct(typeof(CarpentryTableObject), typeof(BoardRecipe), product);
        }
    }

    [Serialized]
    [LocDisplayName("Hardwood Board")]
    [Weight(500)]      
    [Fuel(2000)][Tag("Fuel")]          
    [Currency] 
    [Ecopedia("Items", "Products", createAsSubPage: true, display: InPageTooltip.DynamicTooltip)]                                                                           
    [Tag("WoodBoard", 1)]
    [Tag("Burnable Fuel", 1)]                                 
    public partial class HardwoodBoardItem :
    Item                                    
    {
        public override LocString DisplayDescription { get { return Localizer.DoStr("A higher quality hardwood board used for long lasting furniture."); } }
    }
}
