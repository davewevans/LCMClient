#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37e6d88d18479d0b6dee1b2383f494e63e1d9481"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
using LCMClient.Features.Orphans.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
using LCMClient.Features.Shared.Narrations;

#line default
#line hidden
#nullable disable
    public partial class OrphanNarrations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                   showDelConfirmDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                             $"Are you sure you want to delete this record?"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n\r\n    ");
            __builder.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(5);
            __builder.AddAttribute(6, "HeaderText", "Narrations");
            __builder.AddAttribute(7, "ButtonOnclickHandler", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                            OnAddClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ButtonIcon", "fa fa-plus");
            __builder.AddAttribute(9, "ButtonText", "Add");
            __builder.AddAttribute(10, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "<div style=\"margin-top:2px;\"><i class=\"fa fa-sticky-note text-white text-2xl\"></i></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "m-10");
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
          
            switch (viewMode)
            {
                case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Shared.Narrations.NarrationCreationDialog>(16);
            __builder.AddAttribute(17, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                      Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "Guardian", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Guardians.Models.GuardianDetailsModel>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                       null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                               OnAddNewComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                    break;
                case ViewMode.Edit:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Shared.Narrations.NarrationEditDialog>(21);
            __builder.AddAttribute(22, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                    true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "NarrationRecord", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Shared.Narrations.NarrationEditModel>(
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                           narrationEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "NarrationId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                       narrationIdToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnEditComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                         OnEditComplete

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 36 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                    break;
                case ViewMode.List:
                    break;
            }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
         if (Orphan is not null && Orphan.Narrations is not null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "w-full");
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                 foreach (var narration in Orphan.Narrations)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "flex justify-end text-lg font-semibold mr-10");
            __builder.AddAttribute(32, "style", "margin-top:4px;");
            __builder.AddMarkupContent(33, "\r\n                            Entry Date: ");
            __builder.AddContent(34, 
#nullable restore
#line 50 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                          $"{narration.EntryDate:d}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "p-8");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "flex items-center border-bottom border-b-2 border-gray-900 mb-6");
            __builder.OpenElement(40, "p");
            __builder.AddAttribute(41, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(42, 
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                                                    narration.Subject

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "flex items-center mb-6");
            __builder.OpenElement(46, "p");
            __builder.AddAttribute(47, "class", "md:text-xl text-blue-900 font-semibold");
            __builder.AddContent(48, 
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                                                   narration.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n                        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "flex items-center justify-end mt-4 bg-gray-800 p-6");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "class", "mr-4");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                                         () => OnEditClick(narration)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "<i class=\"fa fa-edit text-2xl text-blue-400\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "mr-4");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                                                         () => OnDeleteClick(narration.NarrationID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<i class=\"fa fa-trash text-2xl text-red-400\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "p");
            __builder.AddContent(64, "No narration records found for ");
            __builder.AddContent(65, 
#nullable restore
#line 75 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
                                               Orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanNarrations.razor"
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
