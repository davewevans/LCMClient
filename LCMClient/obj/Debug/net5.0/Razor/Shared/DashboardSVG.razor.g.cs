#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\DashboardSVG.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84cba565c9321c5f5bd3106f55049e8da5175918"
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
    public partial class DashboardSVG : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "svg");
            __builder.AddAttribute(1, "class", (
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\DashboardSVG.razor"
             _height

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\DashboardSVG.razor"
                      _width

#line default
#line hidden
#nullable disable
            ) + " flex-no-shrink" + " fill-current");
            __builder.AddAttribute(2, "viewBox", "0 0 20 20");
            __builder.AddAttribute(3, "fill", "none");
            __builder.AddAttribute(4, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddMarkupContent(5, "<path d=\"M2 10C2 5.58172 5.58172 2 10 2V10H18C18 14.4183 14.4183 18 10 18C5.58172 18 2 14.4183 2 10Z\" fill=\"currentColor\"></path>\r\n    <path d=\"M12 2.25195C14.8113 2.97552 17.0245 5.18877 17.748 8.00004H12V2.25195Z\" fill=\"currentColor\"></path>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Shared\DashboardSVG.razor"
       
    [Parameter]
    public int Width { get; set; } = 6;

    [Parameter]
    public int Height { get; set; } = 6;

    private string _width = "w-6";
    private string _height = "h-6";

    protected override void OnInitialized()
    {
        _width = $"w-{Width}";
        _height = $"h-{Height}";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
