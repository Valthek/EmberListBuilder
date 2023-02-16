using EmberListBuilder.Domain.Enums;

namespace EmberListBuilder.Domain.Map;

public class Part
{
    public string? Name { get; set; }
    public int Cost { get; set; }
    public string? ImageUrl { get; set; }
    public ComponentType Type { get; set; }
    public string Id { get; set; }
    public Manufacturer Manufacturer { get; set; }

    public Part()
    {
        Name = "No Part Selected";
        Cost = 0;
        ImageUrl = null;
        Type = ComponentType.Default;
        // 000 indicates a non-specific or non-selected part
        Id = "000";
    }

    public Part(ComponentType type, Manufacturer manufacturer)
    {
        Type = type;
        Manufacturer = manufacturer;
        // 000 indicates a non-specific or non-selected part
        Id = "000";
    }
}