using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Domain.Map;
using EmberListBuilder.Persistence.Dummy_Data;
using Microsoft.AspNetCore.Components;

namespace EmberListBuilder.Application.Pages;

public class PartSelectorBase : ComponentBase
{
    [Parameter]
    public int PartType { get; set; }
    [Parameter]
    public int CurrentPart { get; set; }
    public List<Part> AvailableParts { get; set; }
    public Part SelectedPart { get; set; }
    public Part EquippedPart { get; set; }

    public  bool loaded;

    public PartSelectorBase()
    {
        FetchPartsForPartType(PartType);
        if (AvailableParts != null)
            loaded = true;
    }

    private void FetchPartsForPartType(int partType)
    {
        AvailableParts  = DummyDataProvider.GetDummyPartsList().Where(part => part.Type == (ComponentType)partType).ToList();
    }

    protected void SetSelectedPart(Part newPart)
    {
        SelectedPart = newPart;
    }

    protected void EquipNewPart()
    {
        EquippedPart = SelectedPart;
    }

    protected void ClearSelectedPart()
    {
        SelectedPart = null;
    }
}