using System.Text.Json;
using EmberListBuilder.Domain.Map;

namespace EmberListBuilder.Persistence.Dummy_Data;

public static class DummyDataProvider
{
    public static PartData[] GetDummyPartsList()
    {
        using FileStream stream = File.OpenRead("DummyPartData.json");
        return JsonSerializer.Deserialize<PartData[]>(stream) ?? Array.Empty<PartData>();
    }
}