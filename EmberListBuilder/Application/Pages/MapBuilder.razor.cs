﻿using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Domain.Map;
using Microsoft.AspNetCore.Components;

namespace EmberListBuilder.Application.Pages
{
    public partial class MapBuilderBase : ComponentBase
    {
        [Parameter]
        public String MapId { get; set; }

        protected PartData[] DummyParts { get; set; }

        public MapBuilderBase()
        {
            DummyParts = new PartData[]{new PartData
                {
                    Name = "Core",
                    Cost = 25, 
                    ImageUrl = "images/dummy_chassis.png", 
                    Type = ComponentType.Core,
                },
            };
        }
    }
}
