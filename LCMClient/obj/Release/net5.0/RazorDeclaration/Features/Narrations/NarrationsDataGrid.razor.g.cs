// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LCMClient.Features.Narrations
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using LCMClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using LCMClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Narrations\NarrationsDataGrid.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Narrations\NarrationsDataGrid.razor"
using LCMClient.Features.Shared.Narrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Narrations\NarrationsDataGrid.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Narrations\NarrationsDataGrid.razor"
using LCMClient.Services;

#line default
#line hidden
#nullable disable
    public partial class NarrationsDataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Narrations\NarrationsDataGrid.razor"
       

    private bool readyForGrid = false;

    private string apiUrl = "";

    private SfGrid<NarrationModel> NarrationDataGrid = new SfGrid<NarrationModel>();

    public static string searchTerm = "";
    public Query Qry = new Query();
    private string ProfileBtnContent = "View/Edit";

    public List<NarrationModel> Narrations { get; set; }

    public List<string> ToolbarItems = new List<string> {"ExcelExport", "PdfExport", "Search"};

    public int[] PageSizes = {5, 10, 20, 50, 100};
    private int pageSize = 20;

    protected override async Task OnInitializedAsync()
    {
        apiUrl = $"{httpService.BaseUrl}narrations/narrationsSFDataGrid/all";
        readyForGrid = true;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.FocusInput("all-button");
        }
    }

    private async Task OnAllButtonClickHandler()
    {
        apiUrl = $"{httpService.BaseUrl}narrations/narrationsSFDataGrid/all";
        NarrationDataGrid.DataManager.Url = apiUrl;
        NarrationDataGrid.Refresh();
        await jsRuntime.ConsoleLog("OnAllButtonClickHandler");
    }

    private async Task OnApprovedButtonClickHandler()
    {
        apiUrl = $"{httpService.BaseUrl}narrations/narrationsSFDataGrid/approved";
        NarrationDataGrid.DataManager.Url = apiUrl;
        NarrationDataGrid.Refresh();
        await jsRuntime.ConsoleLog("OnApprovedButtonClickHandler");
    }

    private async Task OnRejectedButtonClickHandler()
    {
        apiUrl = $"{httpService.BaseUrl}narrations/narrationsSFDataGrid/rejected";
        NarrationDataGrid.DataManager.Url = apiUrl;
        NarrationDataGrid.Refresh();
        await jsRuntime.ConsoleLog("OnRejectedButtonClickHandler");
    }

    public async Task ActionBeginHandler(ActionEventArgs<NarrationModel> args)
    {
    // Add to query string parameters for search and sorting
        if (string.IsNullOrWhiteSpace(args.SearchString)) await NarrationDataGrid.Search("");
        Qry.AddParams("SearchTerm", args.SearchString);

        if (!string.IsNullOrWhiteSpace(args.ColumnName))
            Qry.AddParams("ColumnName", args.ColumnName);

        Qry.AddParams("SortDirection", args.Direction);
    }

    public async Task ToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id.Contains("excelexport"))
        {
            await this.NarrationDataGrid.ExcelExport();
        }

        if (args.Item.Id.Contains("pdfexport"))
        {
            await this.NarrationDataGrid.PdfExport();
        }
    }

    private void NavigateToDetails(int id)
    {
        navigationManager.NavigateTo($"/NarrationDetails/{id}");
    }

    public void RecordClickHandler(RecordClickEventArgs<NarrationModel> args)
    {
        navigationManager.NavigateTo($"/NarrationDetails/{args.RowData.NarrationID}");
    }

    public void Load(object args)
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService httpService { get; set; }
    }
}
#pragma warning restore 1591
