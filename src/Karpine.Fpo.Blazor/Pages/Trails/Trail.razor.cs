using System.Threading;
using System;
using System.Collections.Generic;
using Syncfusion.Blazor.Grids;
using Karpine.Fpo.Crops;
using System.Threading.Tasks;
using Syncfusion.Blazor.Navigations;

namespace Karpine.Fpo.Blazor.Pages.Trails
{
    public partial class Trail
    {
        private IReadOnlyList<CropDto> InventoryList { get; set; }
        public SfGrid<CropDto> InventoriesGrid;
        private List<Object> ToolbaritemsInventory = new List<Object>() { "Print", "PdfExport", "ExcelExport", new ItemModel() { Text = "Refresh", TooltipText = "Refresh", PrefixIcon = "e-refresh", Id = "Refresh" }, "Search", "ColumnChooser" };
        public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {

            if (args.Item.Id == "Refresh")
            {
                this.InventoriesGrid.Refresh();
            }
            else if (args.Item.Id.Contains("pdfexport"))
            {
                await this.InventoriesGrid.PdfExport();
            }
            else if (args.Item.Id.Contains("excelexport"))
            {
                await this.InventoriesGrid.ExportToExcelAsync();
            }
            else if (args.Item.Id.Contains("csvexport"))
            {
                await this.InventoriesGrid.ExportToCsvAsync();
            }
        }
        private async Task GetInventorysAsync()
        {
            try
            {
               
                await InvokeAsync(() => StateHasChanged());
           
                var result = await CropAppService.GetListAsync();
                InventoryList = result.Items;
            }
            finally
            {
         
                await InvokeAsync(() => StateHasChanged());
            }
        }

        public Trail()
        {
            InventoryList = new List<CropDto>();
         
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await GetInventorysAsync();
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        private async Task ViewInventoryAsync(CropDto inventory)
        {
      
            UriHelper.NavigateTo($"/InventoryTrailSummary/{inventory.SoilTestId.ToString()}");
        }
    }
}
