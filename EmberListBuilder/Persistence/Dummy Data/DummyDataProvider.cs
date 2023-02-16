
using System.Text.Json;
using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Domain.Map;

namespace EmberListBuilder.Persistence.Dummy_Data;

public static class DummyDataProvider
{
    public static List<Part> GetDummyPartsList()
    {
        return new List<Part>()
        {
            new Part()
            {

                Name = "dummy chassis",
                Cost = 5,
                ImageUrl = "images/dummy_chassis.png",
                Type = ComponentType.Chassis
            },
            new Part()
            {

                Name = "expensive dummy chassis",
                Cost = 25,
                ImageUrl = "images/dummy_chassis.png",
                Type = ComponentType.Chassis
            },
            new Part()
            {
                Name = "medium core",
                Cost = 25,
                ImageUrl = "images/dummy_core.png",
                Type = ComponentType.Core
            }, new Part()
            {
                Name = "cheap core",
                Cost = 10,
                ImageUrl = "images/dummy_core.png",
                Type = ComponentType.Core
            }, new Part()
            {
                Name = "expensive core",
                Cost = 50,
                ImageUrl = "images/dummy_core.png",
                Type = ComponentType.Core
            },
            new Part()
            {
                Name = "dummyLeft",
                Cost = 5,
                ImageUrl = "images/dummy_Left.png",
                Type = ComponentType.Left
            },
            new Part()
            {
                Name = "dummyRight",
                Cost = 5,
                ImageUrl = "images/dummy_right.png",
                Type = ComponentType.Right
            },
            new Part()
            {
                Name = "dummySystem",
                Cost = 5,
                ImageUrl = "images/dummy_system.png",
                Type = ComponentType.System
            }
        };

    }
}