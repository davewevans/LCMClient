#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0134073e967c981acdd92a8a86d763237eed833c"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Sponsors.Components
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
using LCMClient.Services;

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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
    public partial class SponsorOrphans : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(0);
            __builder.AddAttribute(1, "HeaderText", "Orphans");
            __builder.AddAttribute(2, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "text-white");
                __builder2.OpenComponent<LCMClient.Shared.OrphanSVG>(6);
                __builder2.AddAttribute(7, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
                          8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
                                     8

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Shared.LoadingAnimation>(9);
            __builder.CloseComponent();
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "m-6");
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
     if (orphans is not null)
    {
        if (orphans.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<p class=\"text-lg font-semibold\">This guardian has no assigned orphans.</p>\r\n            ");
            __builder.AddMarkupContent(13, "<p class=\"text-lg\">To assign an orphan to this guardian, select the orphan from the orphan\'s list, click on \"View/Edit,\" and then click on the \"Guardian\" tab. From there, you can assign this guardian to the selected orphan.</p>");
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Shared.OrphanCards>(14);
            __builder.AddAttribute(15, "Orphans", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<LCMClient.Features.Shared.Models.OrphanModel>>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
                                                             orphans

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<p class=\"text-lg font-semibold\">This guardian has no assigned orphans.</p>\r\n        ");
            __builder.AddMarkupContent(17, "<p class=\"text-lg\">To assign an orphan to this guardian, select the orphan from the orphan\'s list, click on \"View/Edit,\" and then click on the \"Guardian\" tab. From there, you can assign this guardian to the selected orphan.</p>");
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorOrphans.razor"
       

    [Parameter]
    public int Id { get; set; }

    private List<OrphanModel> orphans;

    private bool isLoading = true;

    protected override async Task OnParametersSetAsync()
    {
        orphans = await sponsorRepository.GetSponsorOrphansAsync(Id);
        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISponsorRepository sponsorRepository { get; set; }
    }
}
#pragma warning restore 1591
