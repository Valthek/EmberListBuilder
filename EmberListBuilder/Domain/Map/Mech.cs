namespace EmberListBuilder.Domain.Map;

public class Mech
{
    public Mech(Pilot pilot, Part core, Part chassis, Part leftArm, Part rightArm, Part supportSystem,  Part other)
    {
        Core = core;
        Chassis = chassis;
        LeftArm = leftArm;
        RightArm = rightArm;
        SupportSystem = supportSystem;
        Pilot = pilot;
        Other = other;
    }
    
    public Part Core { get; set; }
    public Part Chassis { get; set; }
    public Part LeftArm { get; set; }
    public Part RightArm { get; set; }
    public Part SupportSystem { get; set; }
    public Pilot Pilot { get; set; }
    public Part Other{ get; set; }
}