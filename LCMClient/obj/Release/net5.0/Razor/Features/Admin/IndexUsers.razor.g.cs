#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "328abce831920be4bfc4b1f1b39e79e8e912ee33"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Admin
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Features.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
using LCMClient.Features.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    public partial class IndexUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
 if (isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Shared.LoadingAnimation>(0);
            __builder.CloseComponent();
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
 if (users != null && users.Response != null && users?.Response?.Count != 0 && !isLoading)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<MudBlazor.MudSimpleTable>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, @"<thead><tr><th><span class=""font-semibold"">First Name</span></th>
                <th><span class=""font-semibold"">Last Name</span></th>
                <th><span class=""font-semibold"">Email Name</span></th>
                <th><span class=""font-semibold"">Role</span></th>
                <th><div class=""flex justify-center""><span class=""font-semibold"">
                            Reset Password
                        </span></div></th>
                <th><div class=""flex justify-center""><span class=""font-semibold"">
                            Edit
                        </span></div></th>
                <th><div class=""flex justify-center""><span class=""font-semibold"">
                            Delete
                        </span></div></th></tr></thead>
        ");
                __builder2.OpenElement(4, "tbody");
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
             foreach (var user in users.Response)
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
#line 61 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                   user.FirstName

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
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                   user.LastName

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
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                   user.Email

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
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                   user.Role

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
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                              () => ResetPasswordHandler(user.UserID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "<img src=\"images/password-reset-30x30.png\" width=\"30\" height=\"30\">");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "td");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "flex justify-center");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(38);
                __builder2.AddAttribute(39, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                  Icons.Material.Edit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                     () => EditUserHandler(user.UserID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                  Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenElement(43, "td");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "flex justify-center");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(46);
                __builder2.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                  Icons.Material.Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                     () => DeleteUserHandler(user.UserID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 91 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
                                                  Color.Error

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 96 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 100 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
}
else if (users?.Response?.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "<p>No application users found</p>");
#nullable restore
#line 104 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\IndexUsers.razor"
       
    private PaginatedResponse<List<UserModel>> users = new PaginatedResponse<List<UserModel>>();
    private bool isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        var pagination = new PaginationModel { Page = 1, RecordsPerPage = 50 };
        users = await userRepository.GetUsers(pagination);

        // await Task.Delay(3000);
        isLoading = false;
    }

    private void EditUserHandler(string userId)
    {
        navigationManager.NavigateTo($"/editUser/{userId}");
    }

    private async Task DeleteUserHandler(string userId)
    {
        if (await ShowConfirmDeleteDialog())
        {
            await userRepository.DeleteUser(userId);
            var userToDelete = users.Response.FirstOrDefault(x => x.UserID.Equals(userId));
            users.Response.Remove(userToDelete);
            StateHasChanged();
            ShowDeleteSuccessSnackbar();
        }
    }

    private async Task<bool> ShowConfirmDeleteDialog()
    {
        var Options = new MudBlazor.Dialog.DialogOptions() { CloseButton = true };
        var Parameters = new DialogParameters();
        Parameters.Add("Message", "Are you sure you want to delete this user?");
        var userSelect = Dialog.Show<ConfirmDeleteDialog>("Confirm Delete", Parameters, Options);
        var result = await userSelect.Result;

        if (result.Cancelled)
        {
            return false;
        }
        return true;
    }

    private async Task ResetPasswordHandler(string userId)
    {
        await jsRuntime.ConsoleLog("user id: " + userId);
        navigationManager.NavigateTo($"/resetPassword/{userId}");
    }

    private void ShowDeleteSuccessSnackbar()
    {
        Toaster.Add("User successfully deleted.", MatToastType.Success, "", "", config =>
        {
            config.ShowProgressBar = false;
            config.RequireInteraction = false;
        });
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService Dialog { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountsRepository accountsRepository { get; set; }
    }
}
#pragma warning restore 1591
