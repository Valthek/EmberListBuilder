using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Domain.Map;
using Microsoft.AspNetCore.Components;

namespace EmberListBuilder.Application.Pages
{
    public class MapBuilderBase : ComponentBase
    {
        [Parameter]
        public String MapId { get; set; }

        protected Mech CurrentMech { get; set; }

        public MapBuilderBase()
        {
            CurrentMech = new Mech("",
                new Part
                {
                    Name = "No Core Selected",
                    Type = ComponentType.Core,
                    Cost = 0,
                    ImageUrl = ""
                },
              new Part
              {
                  Name = "No Chassis Selected",
                  Type = ComponentType.Chassis,
                  Cost = 0,
                  ImageUrl = ""
              },
                new Part
                {
                    Name = "No Right Arm Selected",
                    Type = ComponentType.Right,
                    Cost = 0,
                    ImageUrl = ""
                },
                new Part
                {
                    Name = "No Left Arm Selected",
                    Type = ComponentType.Left,
                    Cost = 0,
                    ImageUrl = ""
                },
                 new Part
                 {
                     Name = "No Support System Selected",
                     Type = ComponentType.System,
                     Cost = 0,
                     ImageUrl = ""
                 },
                new Pilot()
                {
                    Cost = 0,
                    Name = "No Pilot Selected",
                    ImageUrl = ""
                },
                new Part()
                {
                    Name = "No extra part selected",
                    Cost = 0,
                    ImageUrl = "",
                    Type = ComponentType.Other
                });
        }
    }
}
