using Microsoft.AspNetCore.Components;
using EmberListBuilder.Domain.Map;
using EmberListBuilder.Domain.Enums;
using EmberListBuilder.Persistence.Dummy_Data;

namespace EmberListBuilder.Pages.Components
{
    public partial class PartDisplayBase : ComponentBase
    {
        [Parameter]
        public int Type { get; set; }
        [Parameter]
        public Part? DisplayedPart { get; set; }

        public PartDisplayBase()
        {
            DisplayedPart = DummyDataProvider.GetDummyPartsList()[0];
        }
    }
}