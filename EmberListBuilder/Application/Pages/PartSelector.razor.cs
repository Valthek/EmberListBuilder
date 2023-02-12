using EmberListBuilder.Domain.Map;
using Microsoft.AspNetCore.Components;

namespace EmberListBuilder.Application.Pages;

public class PartSelectorBase : ComponentBase
{
    [ParameterAttribute]
    public int ComponentType { get; set; }
    public PartData[] AvailableParts { get; set; }

    public PartSelectorBase()
    {
        Console.WriteLine("test");
    }
}