#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b6118354768362a0048d705a65f79a7441ec04"
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
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "m-10");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "md:flex mt-4 mb-8 bg-blue-100 p-4 items-center justify-between");
            __builder.AddMarkupContent(9, "<div class=\"flex items-center text-blue-600\"><div class=\"mr-3 text-yellow-600\"><svg class=\"h-12 w-12\" version=\"1.1\" x=\"0px\" y=\"0px\" viewBox=\"0 0 31.893 37.149\" xmlns=\"http://www.w3.org/2000/svg\"><path d=\"M 7.06 28.713 L 7.06 33.65 C 7.06 34.332 7.675 34.884 8.432 34.884 L 12.55 34.884 C 13.308 34.884 13.922 34.332 13.922 33.65 L 13.922 28.713 L 19.413 28.713 L 19.413 27.943 L 19.185 27.561 C 18.669 27.074 18.296 26.467 18.134 25.787 L 13.922 18.684 L 13.922 14.944 L 18.039 21.356 L 18.039 21.308 C 18.039 20.103 18.694 19.041 19.685 18.365 C 19.522 17.929 19.413 17.471 19.413 16.988 C 19.413 16.726 19.448 16.473 19.497 16.225 L 15.162 9.471 C 14.029 10.662 12.368 11.433 10.492 11.433 C 8.534 11.433 6.808 10.594 5.674 9.313 C 4.864 9.742 4.315 10.528 4.315 11.433 L 4.315 20.073 C 4.315 20.778 4.648 21.412 5.177 21.86 L 1.113 28.713 L 7.06 28.713 Z\" fill=\"currentColor\" style></path>\r\n                    <circle cx=\"11.51\" cy=\"7.331\" r=\"3.5\" fill=\"currentColor\" style transform=\"matrix(1.372416, 0, 0, 1.234267, -5.305199, -3.169191)\"></circle>\r\n                    <path d=\"M 24.215 21.308 C 22.606 21.308 21.185 20.585 20.315 19.489 C 19.763 19.94 19.413 20.584 19.413 21.308 L 19.413 23.776 L 19.413 25.01 C 19.413 25.921 19.966 26.709 20.784 27.137 L 20.784 33.65 C 20.784 34.332 21.399 34.884 22.156 34.884 L 26.274 34.884 C 27.033 34.884 27.647 34.332 27.647 33.65 L 27.647 27.137 C 28.464 26.709 29.019 25.922 29.019 25.01 L 29.019 23.776 L 29.019 21.308 C 29.019 20.584 28.668 19.941 28.117 19.489 C 27.244 20.585 25.825 21.308 24.215 21.308 Z\" fill=\"currentColor\" style></path>\r\n                    <circle cx=\"21.51\" cy=\"16.331\" r=\"2.5\" fill=\"currentColor\" style transform=\"matrix(1.372416, 0, 0, 1.234267, -5.305199, -3.169191)\"></circle></svg></div>\r\n            <h3 class=\"text-2xl font-semibold mt-1\">Guardian</h3></div>");
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
         if (Orphan?.Guardian == null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                  OnAddClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded");
            __builder.AddMarkupContent(15, "<div class=\"flex items-center\"><i class=\"fa fa-plus mr-2\"></i> Add\r\n                    </div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
      
        switch (viewMode)
        {
            case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.GuardianAssignmentDialog>(16);
            __builder.AddAttribute(17, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                            OnAddNewComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                break;
            case ViewMode.List:
                break;
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
     if (Orphan?.Guardian != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "w-full");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "p-8");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(28, "<label class=\"md:text-2xl font-semibold mr-6\">First Name</label>\r\n                        ");
            __builder.OpenElement(29, "p");
            __builder.AddAttribute(30, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(31, 
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(35, "<label class=\"md:text-2xl font-semibold mr-4\">Last Name</label>\r\n                        ");
            __builder.OpenElement(36, "p");
            __builder.AddAttribute(37, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(38, 
#nullable restore
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(42, "<label class=\"md:text-2xl font-semibold mr-6\">Location</label>\r\n                        ");
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(45, 
#nullable restore
#line 68 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.Guardian.Location

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "flex items-center mb-6");
            __builder.AddMarkupContent(49, "<label class=\"md:text-2xl font-semibold mr-6\">Relationship</label>\r\n                        ");
            __builder.OpenElement(50, "p");
            __builder.AddAttribute(51, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(52, 
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                            Orphan.RelationshipToGuardian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "ml-2");
            __Blazor.LCMClient.Features.Orphans.Components.OrphanGuardian.TypeInference.CreateSfInPlaceEditor_0(__builder, 56, 57, 
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   RenderMode.Inline

#line default
#line hidden
#nullable disable
            , 58, 
#nullable restore
#line 75 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                         EditableType.Click

#line default
#line hidden
#nullable disable
            , 59, 
#nullable restore
#line 76 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Syncfusion.Blazor.InPlaceEditor.InputType.Text

#line default
#line hidden
#nullable disable
            , 60, 
#nullable restore
#line 77 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                           Orphan.RelationshipToGuardian

#line default
#line hidden
#nullable disable
            , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Orphan.RelationshipToGuardian = __value, Orphan.RelationshipToGuardian)), 62, () => Orphan.RelationshipToGuardian, 63, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.InPlaceEditor.InPlaceEditorEvents<string>>(64);
                __builder2.AddAttribute(65, "SubmitClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.InPlaceEditor.ButtonClickArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.InPlaceEditor.ButtonClickArgs>(this, 
#nullable restore
#line 78 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
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
            __builder.AddMarkupContent(66, "\r\n\r\n                ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "flex items-center justify-end mt-4 bg-gray-800 p-6");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "mr-4");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                                 OnRemoveClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "<h3 class=\"text-2xl text-red-400\">Remove</h3>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "p");
            __builder.AddAttribute(75, "class", "text-2xl");
            __builder.AddContent(76, "No guardian found for ");
            __builder.AddContent(77, 
#nullable restore
#line 95 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
                                                   Orphan?.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanGuardian.razor"
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
