// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LCMClient.Features.Shared.Narrations
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using LCMClient.Features.Orphans.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
using LCMClient.Features.Guardians.Models;

#line default
#line hidden
#nullable disable
    public partial class NarrationCreationDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationCreationDialog.razor"
       
    
    [CascadingParameter]
    public Task<AuthenticationState> AuthState { get; set; }

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public GuardianDetailsModel Guardian { get; set; }

    [Parameter]
    public EventCallback<bool> OnAddNewComplete { get; set; }

    [Inject]
    public INarrationRepository NarrationRepository { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    private NarrationCreationModel narrationCreation = new NarrationCreationModel();

    [Inject]
    protected IMatToaster Toaster { get; set; }

    private ElementReference subjectInput;

    private string fullName = "";

    protected override void OnParametersSet()
    {
        fullName = Orphan is not null ? Orphan.FirstName : Guardian?.FullName;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            // Focus the input element
            await JSRuntime.FocusInput("subject");
        }
    }

    private async Task HandleValidSubmit()
    {
        if (Orphan is null && Guardian is null)
        {
            Toaster.Add($" No record found.", MatToastType.Danger);
            return;
        }

        if (Orphan is not null)
        {
            narrationCreation.OrphanID = Orphan.OrphanID;
        }
        else if (Guardian is not null)
        {
            narrationCreation.GuardianID = Guardian.GuardianID;
        }
        
        // get user email to send to API
        var authState = await AuthState;
        var user = authState.User;
        string userEmail = "";
        string emailClaimTypeKey = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        foreach (var claim in authState.User.Claims)
        {
            await JSRuntime.ConsoleLog(claim.Type + " : " + claim.Value);
            if (claim.Type.Equals(emailClaimTypeKey))
            {
                userEmail = claim.Value;
            }
        }

        narrationCreation.SubmittedByEmail = userEmail;

        await NarrationRepository.AddNarrationAsync(narrationCreation);
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(true);
        StateHasChanged();
        Toaster.Add($" Narration record added.", MatToastType.Success);
    }

    private async Task OnCancelBtnClick()
    {
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(false);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
