#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883a2c943e461e235c3c86b1c69fc76c4a2a37d7"
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
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
using LCMClient.Features.Orphans.Enums;

#line default
#line hidden
#nullable disable
    public partial class OrphanAcademics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                             $"Are you sure you want to delete this academic record?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(3, (__value) => {
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                             DeleteConfirmationDialog = (LCMClient.Features.Orphans.Components.SfConfirmDeleteDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "m-10");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "md:flex mt-4 mb-8 bg-blue-100 p-4 items-center justify-between");
            __builder.AddMarkupContent(9, "<div class=\"flex items-center text-blue-600\"><i class=\"fa fa-school text-2xl text-yellow-600 font-bold mr-3\"></i>\r\n            <h3 class=\"text-2xl font-semibold mt-1\">Academics</h3></div>\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                              OnAddClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded");
            __builder.AddMarkupContent(15, "<div class=\"flex items-center\"><i class=\"fa fa-plus mr-2\"></i> Add\r\n                </div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
      
        switch (viewMode)
        {
            case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.AcademicCreationDialog>(16);
            __builder.AddAttribute(17, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                 Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 31 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                          OnAddNewComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                break;
            case ViewMode.Edit:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.AcademicEditDialog>(20);
            __builder.AddAttribute(21, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "AcademicRecord", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.AcademicEditModel>(
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                     academicEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "AcademicId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                 academicIdToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnEditComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                    OnEditComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                break;
            case ViewMode.List:
                break;
        }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
     if (Orphan != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "w-full");
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
             foreach (var academic in Orphan.Academics)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "p-8");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.AddMarkupContent(33, "<label class=\"md:text-2xl font-semibold mr-6\">Date Entered</label>\r\n                            ");
            __builder.OpenElement(34, "p");
            __builder.AddAttribute(35, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(36, 
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                                 $"{academic.EntryDate:d}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.AddMarkupContent(40, "<label class=\"md:text-2xl font-semibold mr-6\">Grade</label>\r\n                            ");
            __builder.OpenElement(41, "p");
            __builder.AddAttribute(42, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(43, 
#nullable restore
#line 58 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                                academic.Grade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.AddMarkupContent(47, "<label class=\"md:text-2xl font-semibold mr-4\">School</label>\r\n                            ");
            __builder.OpenElement(48, "p");
            __builder.AddAttribute(49, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(50, 
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                                academic.School

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.AddMarkupContent(54, "<label class=\"md:text-2xl font-semibold mr-6\">KCPE</label>\r\n                            ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(57, 
#nullable restore
#line 66 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                                academic.KCPE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.AddMarkupContent(61, "<label class=\"md:text-2xl font-semibold mr-6\">KCSE</label>\r\n                            ");
            __builder.OpenElement(62, "p");
            __builder.AddAttribute(63, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(64, 
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                                academic.KCSE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "flex items-center justify-end mt-4 bg-gray-800 p-6");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "mr-4");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                     () => OnEditClick(academic)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "<i class=\"fa fa-edit text-2xl text-blue-400\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "mr-4");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                                                     () => OnDeleteClick(academic.AcademicID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "<i class=\"fa fa-trash text-2xl text-red-400\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(79, "p");
            __builder.AddContent(80, "No academic records found for ");
            __builder.AddContent(81, 
#nullable restore
#line 88 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
                                          Orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanAcademics.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
