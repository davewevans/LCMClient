#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acaf17360d1ad5ab3ac7010198add1016193076d"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
    public partial class OrphanPictures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                   showDelConfirmDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                             $"Are you sure you want to delete this picture?"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(5);
            __builder.AddAttribute(6, "HeaderText", "Photo Album");
            __builder.AddAttribute(7, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "text-white mt-1");
                __builder2.OpenComponent<MudBlazor.MudIcon>(11);
                __builder2.AddAttribute(12, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                        Icons.Material.PhotoAlbum

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                         Size.Medium

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "m-10");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mb-6");
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.OrphanPhotoUpload>(19);
            __builder.AddAttribute(20, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                    Orphan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "IsProfilePhoto", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                             false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "HandlePostUpload", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<LCMClient.Features.Orphans.Models.OrphanDetailsModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(this, 
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                                                       HandlePostUpload

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "grid grid-cols-3 gap-4");
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
          
            if (Orphan?.Pictures != null)
            {
                foreach (var picture in Orphan.Pictures)
                {
                    string picUrl = $"{picture.BaseUrl}{picture.PictureFileName}";
                    string takenDate = picture.TakenDate is null ? $"{picture.EntryDate:d}" : $"{picture.TakenDate:d}";


#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "flex flex-col justify-between border-2 border-blue-900 border-solid rounded bg-blue-100");
            __builder.OpenElement(28, "div");
            __builder.OpenElement(29, "div");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                       picUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "alt", 
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                     Orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "font-semibold m-2 text-center");
            __builder.AddContent(36, 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                             picture.Caption

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "   \r\n                    ");
            __builder.OpenElement(38, "div");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "flex justify-between items-center bg-yellow-200");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "font-mono font-semibold text-blue-600 pl-2");
            __builder.AddContent(43, 
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                 takenDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "pr-2");
            __builder.OpenComponent<MudBlazor.MudIconButton>(47);
            __builder.AddAttribute(48, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                      Icons.Material.Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                     Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                      Color.Error

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                                                          e => OnDeleteHandler(e, picture.PictureID)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPictures.razor"
                   
                }
            }
        

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
