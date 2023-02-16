using Microsoft.AspNetCore.Components;
using EmberListBuilder.Domain.Map;
using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Persistence.Dummy_Data;

namespace EmberListBuilder.Pages.Components
{
    public partial class PartDisplayBase : ComponentBase
    {
        [Parameter]
        public SelectorSizes Size { get; set; }
        [Parameter]
        public int Type { get; set; }
        [Parameter]
        public Part? CurrentPart { get; set; }

        public PartDisplayBase()
        {
            CurrentPart = DummyDataProvider.GetDummyPartsList()[0];
        }

        public string GetPartSelectorSize()
        {
            if (Size == SelectorSizes.Small)
                return "half-width";

            return "full-size";
        }
    }
}