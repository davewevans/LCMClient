#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0294581dfcf70c363652d07b1003fc20c7500b85"
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
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orphanDetails/{id:int}")]
    public partial class OrphanDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Orphans.Components.SfConfirmDeleteDialog>(0);
            __builder.AddAttribute(1, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                            OnConfirmDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                             $"Are you sure you want to delete \"{Orphan?.FullName}\""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(3, (__value) => {
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                             DeleteConfirmationDialog = (LCMClient.Features.Orphans.Components.SfConfirmDeleteDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
 if (Orphan is not null && backgroundIsReady)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "ml-10 mr-10 border-l-2 border-r-2 border-white");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", 
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                     profileBgClass

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "md:flex items-center w-auto rounded-lg p-6");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "w-1/6");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "src", 
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                               Orphan.ProfilePicUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "class", "h-16 w-16 md:h-32 md:w-32 rounded-full mx-auto md:mx-0");
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                                                                          Orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "w-4/6");
            __builder.OpenElement(19, "h1");
            __builder.AddAttribute(20, "class", "text-2xl text-left");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", 
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                      fullNameStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                      Orphan.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "w-1/6");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "submit");
            __builder.AddAttribute(29, "class", "bg-red-700 hover:bg-red-800 text-white font-semibold p-2 border-2 border-gray-700");
            __builder.AddAttribute(30, "value", "DeleteOrphan");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                      OnDeleteClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"fa fa-trash mr-2\"></i> Delete Orphan\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "md:flex ml-10 mr-10 p-4 w-auto bg-yellow-200 border-l-2 border-r-2 border-b-2 border-white");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "w-1/4");
            __builder.AddMarkupContent(37, "<span class=\"text-left font-bold\">Has Guardian:</span> ");
            __builder.OpenElement(38, "span");
            __builder.AddAttribute(39, "class", 
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                                 Summary.HasGuardianStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, 
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                                                            Summary.HasGuardian

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "<br>\r\n            ");
            __builder.AddMarkupContent(42, "<span class=\"text-left font-bold\">Sponsors:</span> ");
            __builder.AddContent(43, 
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                Summary.NumOfSponsors

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, " <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "w-1/4");
            __builder.AddMarkupContent(48, "<span class=\"text-left font-bold\">Age:</span> ");
            __builder.AddContent(49, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                           Summary.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, " <br>\r\n            ");
            __builder.AddMarkupContent(51, "<span class=\"text-left font-bold\">Birthday:</span> ");
            __builder.AddContent(52, 
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                Summary.BirthdayFormatted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "w-1/4");
            __builder.AddMarkupContent(56, "<span class=\"text-left font-bold\">Condition:</span>");
            __builder.AddContent(57, 
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                Summary.Condition

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(58, "<br>\r\n            ");
            __builder.AddMarkupContent(59, "<span class=\"text-left font-bold\">Year of Admission:</span> ");
            __builder.AddContent(60, 
#nullable restore
#line 49 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                         Summary.YearOfAdmission

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "w-1/4");
            __builder.AddMarkupContent(64, "<span class=\"text-left font-bold\">LCM Status:</span> ");
            __builder.OpenElement(65, "span");
            __builder.AddAttribute(66, "class", 
#nullable restore
#line 52 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                               Summary.LCMStatusStyle

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(67, 
#nullable restore
#line 52 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                                                        Summary.LCMStatus

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "<br>\r\n            ");
            __builder.AddMarkupContent(69, "<span class=\"text-left font-bold\">Profile Number:</span> ");
            __builder.AddContent(70, 
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                      Summary.ProfileNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "bg-white ml-10 mr-10 mb-10");
            __builder.OpenComponent<Syncfusion.Blazor.Navigations.SfTab>(73);
            __builder.AddAttribute(74, "CssClass", "tab-adaptive");
            __builder.AddAttribute(75, "OverflowMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.OverflowMode>(
#nullable restore
#line 59 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                              OverflowMode.Scrollable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "HeaderPlacement", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Navigations.HeaderPosition>(
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                 HeaderPosition.Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Navigations.TabItems>(78);
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(80);
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(82);
                        __builder4.AddAttribute(83, "Text", "Profile");
                        __builder4.AddAttribute(84, "IconCss", "orphan-icon");
                        __builder4.AddAttribute(85, "IconPosition", "Left");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(86, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanProfile>(87);
                        __builder4.AddAttribute(88, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(89, "HandleOrphanEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 67 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                             HandleOrphanEdited

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(91);
                    __builder3.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(93);
                        __builder4.AddAttribute(94, "Text", "Academics");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(95, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanAcademics>(96);
                        __builder4.AddAttribute(97, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 75 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                  Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(98, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(99);
                    __builder3.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(101);
                        __builder4.AddAttribute(102, "Text", "Narrations");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(103, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanNarrations>(104);
                        __builder4.AddAttribute(105, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                   Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(106, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(107);
                    __builder3.AddAttribute(108, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(109);
                        __builder4.AddAttribute(110, "Text", "Guardian");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(111, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanGuardian>(112);
                        __builder4.AddAttribute(113, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 91 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                 Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(114, "HandleOrphanEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 91 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                              HandleOrphanEdited

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(115, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(116);
                    __builder3.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(118);
                        __builder4.AddAttribute(119, "Text", "Sponsors");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(120, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanSponsors>(121);
                        __builder4.AddAttribute(122, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 99 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                 Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(123, "HandleOrphanEdited", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 99 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                                              HandleOrphanEdited

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(125);
                    __builder3.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(127);
                        __builder4.AddAttribute(128, "Text", "Pictures");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(129, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanPictures>(130);
                        __builder4.AddAttribute(131, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 107 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                                 Orphan

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(132, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Navigations.TabItem>(133);
                    __builder3.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Navigations.TabHeader>(135);
                        __builder4.AddAttribute(136, "Text", "PDFs");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(137, "ContentTemplate", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<LCMClient.Features.Orphans.Components.OrphanPDFs>(138);
                        __builder4.AddAttribute(139, "Orphan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<LCMClient.Features.Orphans.Models.OrphanDetailsModel>(
#nullable restore
#line 115 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
                                             Orphan

#line default
#line hidden
#nullable disable
                        ));
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
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Shared.LoadingAnimation>(140);
            __builder.CloseComponent();
#nullable restore
#line 125 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanDetails.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(141, @"<style>
    .e-tab .e-tab-header .e-toolbar-item .e-tab-text,
    .e-tab .e-tab-header .e-toolbar-item .e-tab-wrap .e-tab-icon {
        font-size: 18px;
    }

    .e-tab .e-tab-header .e-toolbar-item .e-tab-wrap,
    .e-tab .e-tab-header .e-toolbar-item .e-tab-wrap .e-tab-icon {
        color: #2a4365;
    }

    .e-content .e-item {
        padding: 10px;
        text-align: justify;
    }

    @media screen and (max-width: 425px) {
        .e-tab .e-tab-header .e-toolbar-item .e-tab-text,
        .e-tab .e-tab-header .e-toolbar-item .e-tab-wrap .e-tab-icon {
            font-size: 14px;
        }

        .tab-adaptive {
            overflow: hidden;
        }

            .tab-adaptive .e-content {
                height: inherit !important;
            }

            .tab-adaptive .e-item.e-active {
                overflow: scroll;
            }
    }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591