namespace EmberListBuilder.Domain.Map;

public class Pilot
{
    public Pilot(string name, int cost, string imageUrl)
    {
        Name = name;
        Cost = cost;
        ImageUrl = imageUrl;
    }

    public string Name { get; set; }
    public int Cost { get; set; }
    public string ImageUrl { get; set; }
}