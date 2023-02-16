using EmberListBuilder.Domain.Enums;

namespace EmberListBuilder.Domain.Map;

public class Pilot
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public string ImageUrl { get; set; }
    public string Code { get; set; }
    public Manufacturer Allegiance { get; set; }
}