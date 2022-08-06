using Karpine.Fpo.Crops;
using Syncfusion.Blazor.Kanban;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using System;

namespace Karpine.Fpo.Blazor.Pages.CropStages
{
    public partial class CropStageSummary
    {
        public SfKanban<CropDto> CropKanban;
        private IReadOnlyList<CropDto> cardData { get; set; }
        private bool Loading { get; set; }
        public CropStageSummary()
        {
            cardData = new List<CropDto>();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await GetInventorysAsync();
            }

            await base.OnAfterRenderAsync(firstRender);
        }

    
        private async Task GetInventorysAsync()
        {
            try
            {
                Loading = true;

                var result = await CropAppService.GetCropListByLocationAsync();
                cardData = result;

            }
            finally
            {
                Loading = false;

                await InvokeAsync(() => StateHasChanged());
            }
        }
    }
}
