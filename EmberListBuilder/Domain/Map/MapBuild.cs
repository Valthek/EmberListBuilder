namespace EmberListBuilder.Domain.Map;

public class MapBuild
{
    public MapBuild(string buildId, PartData core, PartData chassis, PartData leftArm, PartData rightArm, PartData supportSystem, Pilot pilot, PartData other)
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
    public PartData Core { get; set; }
    public PartData Chassis { get; set; }
    public PartData LeftArm { get; set; }
    public PartData RightArm { get; set; }
    public PartData SupportSystem { get; set; }
    public Pilot Pilot { get; set; }
    public PartData Other{ get; set; }
}