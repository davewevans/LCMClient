#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c26b86fb02ca550044882bcd2c306cd7cd7672cc"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
using LCMClient.Features.Orphans.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
using LCMClient.Features.Orphans.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
           [Authorize(Roles = "Admin,Staff,OrphanReadWrite,Guest")]

#line default
#line hidden
#nullable disable
    public partial class OrphanSponsors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                   showDelConfirmDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                             $"Are you sure you want remove this sponsor as {Orphan?.FirstName}'s sponsor?"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(5);
            __builder.AddAttribute(6, "Roles", "Admin,Staff,OrphanReadWrite");
            __builder.AddAttribute(7, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(8);
                __builder2.AddAttribute(9, "HeaderText", "Sponsors");
                __builder2.AddAttribute(10, "ButtonOnclickHandler", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                OnAddClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ButtonIcon", "fa fa-plus");
                __builder2.AddAttribute(12, "ButtonText", "Add");
                __builder2.AddAttribute(13, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "text-white");
                    __builder3.OpenComponent<LCMClient.Shared.SponsorSVG>(17);
                    __builder3.AddAttribute(18, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                   8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                              8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(20, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(21);
                __builder2.AddAttribute(22, "HeaderText", "Sponsors");
                __builder2.AddAttribute(23, "ButtonOnclickHandler", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                OnAddClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(24, "ButtonIcon", "fa fa-plus");
                __builder2.AddAttribute(25, "ButtonText", "Add");
                __builder2.AddAttribute(26, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                      false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "text-white");
                    __builder3.OpenComponent<LCMClient.Shared.SponsorSVG>(30);
                    __builder3.AddAttribute(31, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                   8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                              8

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n\r\n\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "m-10");
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
      
        switch (viewMode)
        {
            case ViewMode.AddNew:

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(36);
            __builder.AddAttribute(37, "Roles", "Admin,Staff,OrphanReadWrite");
            __builder.AddAttribute(38, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<LCMClient.Features.Orphans.Components.SponsorAssignmentDialog>(39);
                __builder2.AddAttribute(40, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                          Orphan

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "OnAddNewComplete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                   OnAddNewComplete

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(43, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"

                break;
            case ViewMode.List:
                break;
        }
    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "mt-2 mb-6 flex flex-row justify-center");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                          ShowHideHistoryHandler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "bg-yellow-200 hover:bg-yellow-500 text-blue-900 font-semibold hover:text-white py-2 px-4 rounded");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "flex items-center");
            __builder.OpenElement(51, "i");
            __builder.AddAttribute(52, "class", (
#nullable restore
#line 65 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                           showHideHistoryButtonIcon

#line default
#line hidden
#nullable disable
            ) + " mr-2");
            __builder.CloseElement();
            __builder.AddContent(53, " ");
            __builder.AddContent(54, 
#nullable restore
#line 65 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                 showHideHistoryButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
     if (showHistory)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.OrphanSponsorsHistory>(55);
            __builder.AddAttribute(56, "OrphanHistory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<LCMClient.Features.Orphans.Models.OrphanHistoryDTO>>(
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                              orphanHistory

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 73 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
     if (Orphan?.Sponsors != null && Orphan?.Sponsors.Count() != 0)
    {
        foreach (var sponsor in Orphan.Sponsors)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "w-full");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "w-3/4 border-2 border-gray-600 bg-blue-100 rounded mb-6");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "p-8");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(65, "<label class=\"md:text-2xl font-semibold mr-6\">First Name</label>\r\n                            ");
            __builder.OpenElement(66, "p");
            __builder.AddAttribute(67, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(68, 
#nullable restore
#line 86 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(72, "<label class=\"md:text-2xl font-semibold mr-6\">Last Name</label>\r\n                            ");
            __builder.OpenElement(73, "p");
            __builder.AddAttribute(74, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(75, 
#nullable restore
#line 90 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(79, "<label class=\"md:text-2xl font-semibold mr-6\">Location</label>\r\n                            ");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(82, 
#nullable restore
#line 94 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(86, "<label class=\"md:text-2xl font-semibold mr-6\">City</label>\r\n                            ");
            __builder.OpenElement(87, "p");
            __builder.AddAttribute(88, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(89, 
#nullable restore
#line 98 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(93, "<label class=\"md:text-2xl font-semibold mr-6\">State</label>\r\n                            ");
            __builder.OpenElement(94, "p");
            __builder.AddAttribute(95, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(96, 
#nullable restore
#line 102 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.State

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(100, "<label class=\"md:text-2xl font-semibold mr-6\">Postal Code</label>\r\n                            ");
            __builder.OpenElement(101, "p");
            __builder.AddAttribute(102, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(103, 
#nullable restore
#line 106 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(107, "<label class=\"md:text-2xl font-semibold mr-6\">Email</label>\r\n                            ");
            __builder.OpenElement(108, "p");
            __builder.AddAttribute(109, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(110, 
#nullable restore
#line 110 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                        ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "flex items-center mb-2");
            __builder.AddMarkupContent(114, "<label class=\"md:text-2xl font-semibold mr-6\">Main Phone</label>\r\n                            ");
            __builder.OpenElement(115, "p");
            __builder.AddAttribute(116, "class", "md:text-2xl text-blue-900 font-semibold");
            __builder.AddContent(117, 
#nullable restore
#line 114 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                                sponsor.MainPhone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n                    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "flex items-center justify-between mt-4 bg-gray-800 p-6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(121);
            __builder.AddAttribute(122, "Roles", "Admin,Staff,OrphanReadWrite");
            __builder.AddAttribute(123, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "text-2xl");
                __builder2.OpenElement(126, "a");
                __builder2.AddAttribute(127, "href", "/SponsorDetails/" + (
#nullable restore
#line 122 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                              sponsor.SponsorID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "target", "_blank");
                __builder2.AddMarkupContent(129, "<span class=\"text-blue-500 hover:underline\">Edit Sponsor</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                                ");
                __builder2.OpenElement(131, "button");
                __builder2.AddAttribute(132, "type", "button");
                __builder2.AddAttribute(133, "class", "mr-4");
                __builder2.AddAttribute(134, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 126 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                                             () => OnRemoveClick(sponsor.SponsorID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(135, "<h3 class=\"text-2xl text-red-400\">Remove</h3>");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(136, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 137 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "p");
            __builder.AddAttribute(138, "class", "text-2xl");
            __builder.AddContent(139, "No sponsors found for ");
            __builder.AddContent(140, 
#nullable restore
#line 141 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
                                                   Orphan?.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 142 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanSponsors.razor"
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
