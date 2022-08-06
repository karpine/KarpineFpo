using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Karpine.Fpo;
using Karpine.Fpo.Crops;
using Syncfusion.Blazor.Grids;
using Syncfusion.Blazor.Navigations;
using Syncfusion.Blazor.SplitButtons;
using Karpine.Fpo.Blazor.Helper;


namespace Karpine.Fpo.Blazor.Pages.BlockTrails
{
    public partial class BlockTrailSummary
    {
        [Parameter]
        public string LocationId { get; set; }
        private bool NewDialogOpen = false;
        private bool NewTxDialogOpen = false;
        private MessageResult MsgTx { get; set; }
        private CropDto NewInventoryTrailDto { get; set; }
        private IReadOnlyList<CropDto> InventoryTrailList { get; set; }

        private List<Object> ToolbaritemsInventory = new List<Object>() { "Print", "PdfExport", "ExcelExport", new ItemModel() { Text = "Refresh", TooltipText = "Refresh", PrefixIcon = "e-refresh", Id = "Refresh" }, "Search", "ColumnChooser" };

        public SfGrid<CropDto> InventoryTrailsGrid;

        public BlockTrailSummary()
        {
            InventoryTrailList = new List<CropDto>();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await GetInventoryTrailsAsync();
            }

            await base.OnAfterRenderAsync(firstRender);
        }

        private Task ViewInventoryTrailAsync(CropDto inventoryTrailDto)
        {
            NewDialogOpen = true;
            NewInventoryTrailDto = inventoryTrailDto;
            ViewBlockChainTXAsync(inventoryTrailDto);
            return Task.CompletedTask;
        }
        private Task ViewBlockChainTXAsync(CropDto inventoryTrailDto)
        {
            NewTxDialogOpen = true;
            string url = NodeUrl + $"/api/Message/San:" + inventoryTrailDto.Id.ToString();
            MessageResult messageResult = WebRequestHelper.RetrieveMessageAsync(url).Result;
            MsgTx = messageResult;
            return Task.CompletedTask;
        }

        public string NodeUrl = "https://api.karpine.io";

        private async Task GetInventoryTrailsAsync()
        {
            try
            {

                await InvokeAsync(() => StateHasChanged());

                var result = await CropAppService.GetCropListByItemIdAsync(LocationId);

                InventoryTrailList = result;

            }
            finally
            {

                await InvokeAsync(() => StateHasChanged());
            }
        }
        public async Task ToolbarClickHandler(Syncfusion.Blazor.Navigations.ClickEventArgs args)
        {

            if (args.Item.Id == "Refresh")
            {
                this.InventoryTrailsGrid.Refresh();
            }
            else if (args.Item.Id.Contains("pdfexport"))
            {
                await this.InventoryTrailsGrid.PdfExport();
            }
            else if (args.Item.Id.Contains("excelexport"))
            {
                await this.InventoryTrailsGrid.ExportToExcelAsync();
            }
            else if (args.Item.Id.Contains("csvexport"))
            {
                await this.InventoryTrailsGrid.ExportToCsvAsync();
            }
        }


    }
}
