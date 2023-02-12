using Microsoft.AspNetCore.Components;
using EmberListBuilder.Domain.Map;
using EmberListBuilder.Domain.Enums;

namespace EmberListBuilder.Pages.Components
{
    public partial class PartDisplayBase : ComponentBase
    {
        [Parameter]
        public SelectorSizes Size { get; set; }
        [Parameter]
        public int Type { get; set; }
        [Parameter]
        public PartData? CurrentPart { get; set; }

        public string GetPartSelectorSize()
        {
            if (Size == SelectorSizes.Small)
                return "half-width";

            return "full-size";
        }
    }
}