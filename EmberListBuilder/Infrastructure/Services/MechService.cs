using System.Reflection;
using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Domain.Map;
using EmberListBuilder.Persistence.Dummy_Data;

namespace EmberListBuilder.Infrastructure.Services;

// Service to hold and manage a particular mech's data
public class MechService
{
    public Mech Mech { get; set; }

    public string SetActiveMech(Mech Mech)
    {
        this.Mech = Mech;
        return SerializeMech(Mech);
    }

    public Mech SetActiveMechFromString(string mechCode)
    {
        this.Mech = DeserializeMech(mechCode);
        return this.Mech;
    }

    // Turn a mech into a string that can be used to recreate it
    private static string SerializeMech(Mech mech)
    {
        return $"{mech.Core.Manufacturer.ToString()}" +
               $"{mech.Pilot.Code}" +
               $"{mech.Core.Id}{mech.Chassis.Id}" +
               $"{mech.RightArm.Id}{mech.LeftArm.Id}" +
               $"{mech.SupportSystem.Id}{mech.Other.Id}";
    }

    // Recreate a mech based on a string that can be used for exchanging builds
    private static Mech DeserializeMech(string mechCode)
    {
        var manufacturer = Enum.Parse<Manufacturer>(mechCode.Substring(0, 3));
        var availableParts = DummyDataProvider.GetDummyPartsList().Where(part => part.Manufacturer == manufacturer).ToList();
        var availablePilots = DummyDataProvider.GetDummyPilotList().Where(pilot => pilot.Allegiance == manufacturer).ToList();


        var mechOptions = Enumerable.Range(3, 7)
            .Select(i => mechCode.Substring(i * 3, 3)).ToList();

        var mech = new Mech(
            availablePilots.FirstOrDefault(pilot => pilot.Code == mechOptions[0]) ?? new Pilot(), 
            availableParts.FirstOrDefault(part => part.Id == mechOptions[1] && part.Type == ComponentType.Core) ?? new Part(ComponentType.Core, manufacturer),
            availableParts.FirstOrDefault(part => part.Id == mechOptions[2] && part.Type == ComponentType.Chassis) ?? new Part(ComponentType.Chassis, manufacturer),
            availableParts.FirstOrDefault(part => part.Id == mechOptions[3] && part.Type == ComponentType.Left) ?? new Part(ComponentType.Left, manufacturer),
            availableParts.FirstOrDefault(part => part.Id == mechOptions[4] && part.Type == ComponentType.Right) ?? new Part(ComponentType.Right, manufacturer), 
            availableParts.FirstOrDefault(part => part.Id == mechOptions[5] && part.Type == ComponentType.System) ?? new Part(ComponentType.System, manufacturer),
            availableParts.FirstOrDefault(part => part.Id == mechOptions[6] && part.Type == ComponentType.Other) ?? new Part(ComponentType.Other, manufacturer));

        return mech;
    }
}