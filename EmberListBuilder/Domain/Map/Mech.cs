namespace EmberListBuilder.Domain.Map;

public class Mech
{
    public Mech(string buildId, Part core, Part chassis, Part leftArm, Part rightArm, Part supportSystem, Pilot pilot, Part other)
    {
        BuildId = buildId;
        Core = core;
        Chassis = chassis;
        LeftArm = leftArm;
        RightArm = rightArm;
        SupportSystem = supportSystem;
        Pilot = pilot;
        Other = other;
    }

    public string BuildId { get; set; }
    public Part Core { get; set; }
    public Part Chassis { get; set; }
    public Part LeftArm { get; set; }
    public Part RightArm { get; set; }
    public Part SupportSystem { get; set; }
    public Pilot Pilot { get; set; }
    public Part Other{ get; set; }
}