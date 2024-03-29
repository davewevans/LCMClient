// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LCMClient.Features.Dashboard.Components
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
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Dashboard\Components\OrphanStatisticsComponent.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Dashboard\Components\OrphanStatisticsComponent.razor"
using LegendPosition = Syncfusion.Blazor.Charts.LegendPosition;

#line default
#line hidden
#nullable disable
    public partial class OrphanStatisticsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Dashboard\Components\OrphanStatisticsComponent.razor"
       
    
    OrphanStatistics orphanStatistics = null;
    bool hideLoadingAnimation = false;
    bool hideChart = true;
    bool gotData = false;
    public class PieData
    {
        public string xValue { get; set; }
        public double yValue { get; set; }
        public string text { get; set; }
    }

    public List<PieData> DataSource = new List<PieData>();
    
    protected override async Task OnInitializedAsync()
    {
        orphanStatistics = await DashboardRepository.GetOrphanStatistics();
        
        DataSource = new List<PieData>
        {
            new PieData { xValue = "Active",  yValue = (double)orphanStatistics.ActiveCount, text = orphanStatistics.ActiveCountText },
            new PieData { xValue = "Inactive",  yValue = (double)orphanStatistics.InactiveCount, text = orphanStatistics.InactiveCountText },
            new PieData { xValue = "Unspecified",  yValue = (double)orphanStatistics.UnknownCount, text = orphanStatistics.UnknownCountText },
        };
    }
    
    string CurrentUri;
    
    void BeforeRender(IAccLoadedEventArgs Args)
    {
        CurrentUri = NavigationManager.Uri;
        if (CurrentUri.IndexOf("material") > -1)
        {
            Args.Theme = AccumulationTheme.Material;
        }
        else if (CurrentUri.IndexOf("fabric") > -1)
        {
            Args.Theme = AccumulationTheme.Fabric;
        }
        else if (CurrentUri.IndexOf("bootstrap") > -1)
        {
            Args.Theme = AccumulationTheme.Bootstrap;
        }
        else if (CurrentUri.IndexOf("highcontrast") > -1)
        {
            Args.Theme = AccumulationTheme.HighContrast;
        }
        else
        {
            Args.Theme = AccumulationTheme.Bootstrap4;
        }

        hideChart = false;
        hideLoadingAnimation = true;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDashboardRepository DashboardRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
