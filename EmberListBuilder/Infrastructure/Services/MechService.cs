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

    // Turn a mech into a string that can be used to recreate it
    private string SerializeMech(Mech mech)
    {
        return $"{mech.Core.Manufacturer.ToString()}" +
               $"{mech.Pilot.Code}" +
               $"{mech.Core.Id}{mech.Chassis.Id}" +
               $"{mech.RightArm.Id}{mech.LeftArm.Id}" +
               $"{mech.SupportSystem.Id}{mech.Other.Id}";
    }

    private Mech DeserializeMech(string mechCode)
    {
        Manufacturer manufacturer = Enum.Parse<Manufacturer>(mechCode.Substring(0, 3));
        Mech mech = new Mech(null, null, null, null, null, null, null);
        List<Part> availableParts = DummyDataProvider.GetDummyPartsList().Where(part => part.Manufacturer == manufacturer).ToList();
        List<Pilot> availablePilots = DummyDataProvider.GetDummyPilotList().Where(pilot => pilot.Allegiance == manufacturer).ToList();
        string pilotCode = mechCode.Substring(3, 3);
        mech.Pilot = availablePilots.FirstOrDefault(pilot => pilot.Code == pilotCode) ?? new Pilot();

        PropertyInfo[] mechProperties = mech.GetType().GetProperties();

        var parts = Enumerable.Range(5, 6)
            .Select(i => mechCode.Substring(i * 3, 3));
        foreach (var part in parts)
        {
            
        }

        return null;
    }
}