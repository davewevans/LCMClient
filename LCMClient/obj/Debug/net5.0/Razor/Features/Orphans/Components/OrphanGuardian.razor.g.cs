#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c2aaf434c6d84a209ee626d77f4408ce3a113b"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Orphans.Components
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
using LCMClient.Features.Orphans.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
using Syncfusion.Blazor.InPlaceEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
    public partial class OrphanGuardian : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                   showDelConfirmDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                             $"Are you sure you want remove {Orphan?.Guardian?.FullName} as {Orphan?.FirstName}'s guardian?"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(5);
            __builder.AddAttribute(6, "HeaderText", "Guardian");
            __builder.AddAttribute(7, "ButtonOnclickHandler", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                        OnAddClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ButtonIcon", "fa fa-plus");
            __builder.AddAttribute(9, "ButtonText", "Add");
            __builder.AddAttribute(10, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                Orphan?.Guardian == null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "text-white");
                __builder2.OpenComponent<LCMClient.Shared.GuardianSVG>(14);
                __builder2.AddAttribute(15, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                           8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
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
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "m-10");
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
      
        switch (viewMode)
        {
            case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.GuardianAssignmentDialog>(20);
            __builder.AddAttribute(21, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                            OnAddNewComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 31 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                break;
            case ViewMode.List:
                break;
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
     if (Orphan?.Guardian != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "w-full");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "p-8");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(32, "<label class=\"md:text-2xl font-semibold mr-6\">First Name</label>\r\n                        ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(35, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(39, "<label class=\"md:text-2xl font-semibold mr-4\">Last Name</label>\r\n                        ");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(42, 
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(46, "<label class=\"md:text-2xl font-semibold mr-6\">Location</label>\r\n                        ");
            __builder.OpenElement(47, "p");
            __builder.AddAttribute(48, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(49, 
#nullable restore
#line 52 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(53, "<label class=\"md:text-2xl font-semibold mr-6\">Relationship</label>\r\n                        ");
            __builder.OpenElement(54, "p");
            __builder.AddAttribute(55, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(56, 
#nullable restore
#line 56 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.RelationshipToGuardian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "ml-2");
            __Blazor.LCMClient.Features.Orphans.Components.OrphanGuardian.TypeInference.CreateSfInPlaceEditor_0(__builder, 60, 61, 
#nullable restore
#line 58 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 62, 
#nullable restore
#line 59 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                         EditableType.Click

#line default
#line hidden
#nullable disable
            , 63, 
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Syncfusion.Blazor.InPlaceEditor.InputType.Text

#line default
#line hidden
#nullable disable
            , 64, 
#nullable restore
#line 61 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                           Orphan.RelationshipToGuardian

#line default
#line hidden
#nullable disable
            , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Orphan.RelationshipToGuardian = __value, Orphan.RelationshipToGuardian)), 66, () => Orphan.RelationshipToGuardian, 67, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(68);
                __builder2.AddAttribute(69, "SubmitClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.InPlaceEditor.ButtonClickArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.InPlaceEditor.ButtonClickArgs>(this, 
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                  RelationshipEditHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n                ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "flex items-center justify-end mt-4 bg-gray-800 p-6");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "type", "button");
            __builder.AddAttribute(75, "class", "mr-4");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                 OnRemoveClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(77, "<h3 class=\"text-2xl text-red-400\">Remove</h3>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "text-2xl");
            __builder.AddContent(80, "No guardian found for ");
            __builder.AddContent(81, 
#nullable restore
#line 79 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Orphan?.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.LCMClient.Features.Orphans.Components.OrphanGuardian
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfInPlaceEditor_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::Syncfusion.Blazor.InPlaceEditor.RenderMode __arg0, int __seq1, global::Syncfusion.Blazor.InPlaceEditor.EditableType __arg1, int __seq2, global::Syncfusion.Blazor.InPlaceEditor.InputType __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.InPlaceEditor.SfInPlaceEditor<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Mode", __arg0);
        __builder.AddAttribute(__seq1, "EditableOn", __arg1);
        __builder.AddAttribute(__seq2, "Type", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
