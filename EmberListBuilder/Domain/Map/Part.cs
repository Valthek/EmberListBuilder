using EmberListBuilder.Domain.Enums;

namespace EmberListBuilder.Domain.Map;

public class Part
{
    public string? Name { get; set; }
    public int Cost { get; set; }
    public string? ImageUrl { get; set; }
    public ComponentType Type { get; set; }
}