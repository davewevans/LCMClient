#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c23cdff2f9f2637462a19f0225b64d2ba35af33"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.NarrationsApproval
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
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
using LCMClient.Features.Shared.Narrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
           [Authorize(Roles = "Admin, NarrationApprover")]

#line default
#line hidden
#nullable disable
    public partial class IndexNarrations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Shared.LoadingAnimation>(0);
            __builder.CloseComponent();
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
 if (pendingNarrations != null && pendingNarrations.Response != null && pendingNarrations?.Response?.Count != 0 && !isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudSimpleTable>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, @"<thead><tr><th><span class=""font-semibold"">Submitted On</span></th>
                <th><span class=""font-semibold"">Submitted By</span></th>
                <th><span class=""font-semibold"">Orphan</span></th>
                <th><span class=""font-semibold"">Guardian</span></th>
                <th><div class=""flex justify-center""><span class=""font-semibold"">
                            View Narration
                        </span></div></th></tr></thead>
        ");
                __builder2.OpenElement(4, "tbody");
#nullable restore
#line 50 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
             foreach (var narration in pendingNarrations.Response)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(5, "tr");
                __builder2.OpenElement(6, "td");
                __builder2.OpenElement(7, "span");
                __builder2.AddAttribute(8, "class", "font-normal");
                __builder2.AddContent(9, 
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                     narration.SubmittedAt?.ToShortDateString() ?? ""

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(10, "\r\n                    ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "span");
                __builder2.AddAttribute(13, "class", "font-normal");
                __builder2.AddContent(14, 
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                   narration.SubmittedByName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                    ");
                __builder2.OpenElement(16, "td");
                __builder2.OpenElement(17, "span");
                __builder2.AddAttribute(18, "class", "font-normal");
                __builder2.AddContent(19, 
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                   narration.OrphanName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "td");
                __builder2.OpenElement(22, "span");
                __builder2.AddAttribute(23, "class", "font-normal");
                __builder2.AddContent(24, 
#nullable restore
#line 63 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                   narration.GuardianName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenElement(26, "td");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "flex justify-center");
                __builder2.OpenComponent<MudBlazor.MudButton>(29);
                __builder2.AddAttribute(30, "Class", "mt-2");
                __builder2.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                           Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
                                                                                     () => ViewNarrationHandler(narration.NarrationID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n                                View Narration\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 73 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 77 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
}
else if (pendingNarrations?.Response?.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<p>No pending approval narrations found</p>");
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\NarrationsApproval\IndexNarrations.razor"
       
    // private PaginatedResponse<List<UserModel>> users = new ();
    private PaginatedResponse<List<NarrationModel>> pendingNarrations = new ();

    private bool isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        var pagination = new PaginationModel { Page = 1, RecordsPerPage = 50 };
        // users = await userRepository.GetUsers(pagination);

        pendingNarrations = await narrationRepository.GetPendingApprovalNarrations(pagination);

        // foreach (var narration in pendingNarrations.Response)
        // {
        //     string orphanName = narration.OrphanName ?? "";
        //     string guardianName = narration.GuardianName ?? "";
        //     string submittedByName = narration.SubmittedByName ?? "";
        //     string line = $"Date Sumbittted: {narration.SubmittedAt?.ToShortDateString()} | Submitted By: {submittedByName} | Orphan Name:  {orphanName} | Guardian Name: {guardianName}";
        //     await jsRuntime.ConsoleLog(line);
        // }
        

        // await Task.Delay(3000);
        isLoading = false;
    }

    private async Task ViewNarrationHandler(int narrationId)
    {
        await jsRuntime.ConsoleLog("narration id: " + narrationId);
        navigationManager.NavigateTo($"/NarrationApprovalDetails/{narrationId}");
    }
    
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INarrationRepository narrationRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountsRepository accountsRepository { get; set; }
    }
}
#pragma warning restore 1591
