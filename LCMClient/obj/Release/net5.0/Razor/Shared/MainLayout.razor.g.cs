#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a71f2efac5e99497ee2ba8a12a48b8929b2453c"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Shared
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
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.AddAttribute(1, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.MudTheme>(
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                         CustomMudTheme

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<MudBlazor.Dialog.MudDialogProvider>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(7);
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(9);
                __builder2.AddAttribute(10, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                    Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(13);
                    __builder3.AddAttribute(14, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                              Icons.Material.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                                          Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                                                               Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                                                                                     ToggleDrawer

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(19);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<LCMClient.Shared.LoginDisplay>(21);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(23);
                __builder2.AddAttribute(24, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                      open

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "Clipped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                      clipped

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                                          2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "Style", "background-color:#ffffff;");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudDrawerHeader>(29);
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(31, @"<div class=""flex items-center justify-center mt-2""><div class=""flex items-center bg-white""><img class src=""images/LMCSMS_Icon_60x60_transparent.png"" width=""60"" height=""60"" alt=""Life for Children Ministry"">
                    <span class=""primary-text-color text-xl font-semibold mr-2"">LCM SMS</span></div></div>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n        \r\n        ");
                    __Blazor.LCMClient.Shared.MainLayout.TypeInference.CreateCascadingValue_0(__builder3, 33, 34, "PendingNarrationsCount", 35, 
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
                                                              _pendingNarrationsCount

#line default
#line hidden
#nullable disable
                    , 36, (__builder4) => {
                        __builder4.OpenComponent<LCMClient.Shared.NavMenu>(37);
                        __builder4.CloseComponent();
                    }
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudContainer>(41);
                    __builder3.AddAttribute(42, "Class", "pl-0 pr-0");
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(44, 
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\MainLayout.razor"
       

    string _pendingNarrationsCount = "";

    bool open = true;
    bool clipped = false;

    int counter = 0;

    private void ToggleDrawer()
    {
        open = !open;
    }

    [CascadingParameter] protected Task<AuthenticationState> AuthState { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthState).User;
        if (!user.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
    }


    MudTheme CustomMudTheme = new MudTheme
    {
        Palette = new Palette()
        {
            Primary = "#00529B",
            Secondary = Colors.Orange.Darken1,
            Tertiary = Colors.Blue.Accent1,
        }
    };


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.LCMClient.Shared.MainLayout
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
