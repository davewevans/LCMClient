#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "defbcf60aee80488ef1cbb7731560ef24aa0bdb1"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Shared
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
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    public partial class SfConfirmDeleteDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "400px");
            __builder.AddAttribute(2, "Target", "#target");
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                          IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(7);
                __builder2.AddAttribute(8, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, 
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
             ConfirmationTitle

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.AddAttribute(10, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(11, 
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
             ConfirmationMessage

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogEvents>(13);
                __builder2.AddAttribute(14, "OnOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Popups.BeforeOpenEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Popups.BeforeOpenEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                           BeforeDialogOpen

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "Closed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Popups.CloseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Popups.CloseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                                                      DialogClose

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(17);
                __builder2.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(19);
                    __builder3.AddAttribute(20, "Content", "Yes");
                    __builder3.AddAttribute(21, "CssClass", "confirm-btn");
                    __builder3.AddAttribute(22, "IconCss", "confirm-icon");
                    __builder3.AddAttribute(23, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                                                                                                             OnConfirm

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(26);
                    __builder3.AddAttribute(27, "Content", "Cancel");
                    __builder3.AddAttribute(28, "IconCss", "cancel-icon");
                    __builder3.AddAttribute(29, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
                                                                       OnCancel

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(31, @"<style>

    .e-btn.e-flat.e-primary, .e-btn.e-flat.e-primary:focus {
        background-color: red;
        border-color: #265f91;
        color: #fff;
    }

        .e-btn.e-flat.e-primary:hover, .e-btn.e-flat.e-primary:active {
            background-color: darkred;
            border-color: #163854;
            color: #fff;
        }

    .confirm-icon::before {
        font-family: ""Font Awesome 5 Free"";
        font-weight: 900;
        content: ""\f1f8"";
    }

    .cancel-icon::before {
        font-family: ""Font Awesome 5 Free"";
        font-weight: 900;
        content: ""\f00d"";
    }

    .e-btn-hide {
        display: none;
    }

    .Table {
        border-collapse: separate;
        border-spacing: 10px;
        width: 85%;
        margin: 0px -5px 0px;
    }

    .dlgbtn {
        margin-right: 10px;
    }

    #target {
        height: 460px;
        min-height: 350px;
    }

    .dlgbtn {
        margin-right: 10px;
    }

    .fabric #target #prompt_dialog.e-dialog {
        height: 291px;
    }

    .material #target #prompt_dialog.e-dialog {
        height: 270px;
    }

    #target #prompt_dialog.e-dialog {
        height: 270px;
    }

    .bootstrap4 #target #prompt_dialog.e-dialog {
        height: 285px;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\SfConfirmDeleteDialog.razor"
       

    [Parameter]
    public string ConfirmationTitle { get; set; } = "Confirm Delete";

    [Parameter]
    public string ConfirmationMessage { get; set; } = "Are you sure you want to delete?";

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }

    [Parameter]
    public bool IsVisible { get; set; } = false;


    private bool ShowButtons { get; set; } = true;


    public void ShowDialog()
    {
        this.IsVisible = true;
    }

    private async Task OnConfirm()
    {
        this.IsVisible = false;
        await ConfirmationChanged.InvokeAsync(true);
    }

    private async Task OnCancel()
    {
        this.IsVisible = false;
        await ConfirmationChanged.InvokeAsync(false);
    }

    private void BeforeDialogOpen(Syncfusion.Blazor.Popups.BeforeOpenEventArgs args)
    {
        this.ShowButtons = false;
    }

    private void DialogClose(CloseEventArgs args)
    {
        this.ShowButtons = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
