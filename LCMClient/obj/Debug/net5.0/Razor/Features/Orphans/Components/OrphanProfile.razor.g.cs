#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "021a68d62a8f38df9bca89750e63a0617cfbeff5"
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
    public partial class OrphanProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "md:flex ml-8 mr-8 mt-4 mb-8 bg-blue-100 p-4 items-center justify-between");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class");
            __builder.OpenElement(4, "h3");
            __builder.AddAttribute(5, "class", "text-blue-600 text-2xl");
            __builder.AddAttribute(6, "font-bold");
            __builder.AddContent(7, 
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                                                      Orphan.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(8, "\'s Profile");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                          ToggleEditMode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "bg-transparent hover:bg-blue-500 text-blue-700 font-semibold hover:text-white py-2 px-4 border border-blue-500 hover:border-transparent rounded");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "flex items-center");
            __builder.OpenElement(17, "i");
            __builder.AddAttribute(18, "class", (
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                           editViewIcon

#line default
#line hidden
#nullable disable
            ) + " mr-2");
            __builder.CloseElement();
            __builder.AddContent(19, " ");
            __builder.AddContent(20, 
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                                                    editViewText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
 if (editMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "mb-20");
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.OrphanProfileEdit>(23);
            __builder.AddAttribute(24, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                                    Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "HandleOrphanEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<LCMClient.Features.Orphans.Models.OrphanDetailsModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(this, 
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                                                                 HandleOrphanEditedByChild

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "mb-20");
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.OrphanProfileView>(28);
            __builder.AddAttribute(29, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
                                    Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanProfile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
