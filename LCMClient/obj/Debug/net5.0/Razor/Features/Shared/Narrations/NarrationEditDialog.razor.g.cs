#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b986e81af50716163291181643ce864a1d99505f"
// <auto-generated/>
#pragma warning disable 1591
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
    public partial class NarrationEditDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "400px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ZIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                                                               99999

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogEvents>(8);
                __builder2.AddAttribute(9, "Closed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Popups.CloseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Popups.CloseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                           OnCancelBtnClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(11);
                __builder2.AddAttribute(12, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "<h3 class=\"text-3xl font-semibold\">Edit Narration Record</h3>");
                }
                ));
                __builder2.AddAttribute(14, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "w-full m-6");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(17);
                    __builder3.AddAttribute(18, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                 NarrationRecord

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                                 HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(20, "class", "w-full max-w-lg");
                    __builder3.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(22);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(23, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "w-11/12 px-3 mb-6");
                        __builder4.AddMarkupContent(26, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"subject\">\r\n                            Subject\r\n                        </label>\r\n                        ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                        __builder4.AddAttribute(28, "id", "subject");
                        __builder4.AddAttribute(29, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                NarrationRecord.Subject

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NarrationRecord.Subject = __value, NarrationRecord.Subject))));
                        __builder4.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NarrationRecord.Subject));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                        ");
                        __Blazor.LCMClient.Features.Shared.Narrations.NarrationEditDialog.TypeInference.CreateValidationMessage_0(__builder4, 34, 35, 
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                  () => NarrationRecord.Subject

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(36, "\r\n\r\n                    \r\n                    ");
                        __builder4.OpenElement(37, "div");
                        __builder4.AddAttribute(38, "style", "height:400px;");
                        __builder4.OpenElement(39, "div");
                        __builder4.AddAttribute(40, "class", "w-11/12 h-full px-3 mb-6");
                        __builder4.AddMarkupContent(41, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"note\">\r\n                                Note\r\n                            </label>\r\n                            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(42);
                        __builder4.AddAttribute(43, "id", "note");
                        __builder4.AddAttribute(44, "class", "appearance-none block w-full h-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                        NarrationRecord.Note

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => NarrationRecord.Note = __value, NarrationRecord.Note))));
                        __builder4.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => NarrationRecord.Note));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(48, "\r\n                            ");
                        __Blazor.LCMClient.Features.Shared.Narrations.NarrationEditDialog.TypeInference.CreateValidationMessage_1(__builder4, 49, 50, 
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                      () => NarrationRecord.Note

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(52);
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(54);
                    __builder3.AddAttribute(55, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(57);
                        __builder4.AddAttribute(58, "Content", "Save");
                        __builder4.AddAttribute(59, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 49 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(61);
                    __builder3.AddAttribute(62, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
                                OnCancelBtnClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(64);
                        __builder4.AddAttribute(65, "Content", "Cancel");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(67, @"<style>
    .e-btn.e-flat.e-primary, .e-btn.e-flat.e-primary:focus {
        background-color: #317ab9;
        border-color: #265f91;
        color: #fff;
    }

        .e-btn.e-flat.e-primary:hover, .e-btn.e-flat.e-primary:active {
            background-color: #21527d;
            border-color: #163854;
            color: #fff;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Shared\Narrations\NarrationEditDialog.razor"
       

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public NarrationEditModel NarrationRecord { get; set; }

    [Parameter]
    public int NarrationId { get; set; }

    [Parameter]
    public EventCallback<bool> OnEditComplete { get; set; }

    [Inject]
    public INarrationRepository NarrationRepository { get; set; }

    [Inject]
    public IJSRuntime JSRuntime { get; set; }

    [Inject]
    protected IMatToaster Toaster { get; set; }

    private ElementReference subjectInput;

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
        if (NarrationRecord == null)
        {
            Toaster.Add($" No Narration record found.", MatToastType.Danger);
            return;
        }

        await NarrationRepository.UpdateNarrationAsync(NarrationId, NarrationRecord);
        IsVisible = false;
        await OnEditComplete.InvokeAsync(true);
        StateHasChanged();
        Toaster.Add($" Record updated successfully!", MatToastType.Success);
    }

    private async Task OnCancelBtnClick()
    {
        IsVisible = false;
        await OnEditComplete.InvokeAsync(false);
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.LCMClient.Features.Shared.Narrations.NarrationEditDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
