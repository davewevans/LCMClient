#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc4e53ce3af91907c4112973a3d8aa78da3e8a86"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Guardians.Components
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
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
using LCMClient.Features.Guardians.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
           [Authorize(Roles = "Admin,Staff,GuardianReadWrite")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/guardianCreation")]
    public partial class GuardianCreation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                  newGuardian

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                               HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCard>(6);
                __builder2.AddAttribute(7, "Class", "my-mud-card-form");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(9);
                    __builder3.AddAttribute(10, "Class", "mud-card-header");
                    __builder3.AddAttribute(11, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(12);
                        __builder4.AddAttribute(13, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(15, "Add New Guardian");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(16, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(17);
                        __builder4.AddAttribute(18, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                      Icons.Material.Cancel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                                                    Color.Default

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(20, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                                                                             OnCancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(22);
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(24, "div");
                        __builder4.AddAttribute(25, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(26, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"firstName\">\r\n                    First Name\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                        __builder4.AddAttribute(28, "id", "firstName");
                        __builder4.AddAttribute(29, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.FirstName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.FirstName = __value, newGuardian.FirstName))));
                        __builder4.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.FirstName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(33, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_0(__builder4, 34, 35, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.FirstName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(36, "\r\n\r\n            \r\n            ");
                        __builder4.OpenElement(37, "div");
                        __builder4.AddAttribute(38, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(39, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"lastName\">\r\n                    Last Name\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                        __builder4.AddAttribute(41, "id", "lastName");
                        __builder4.AddAttribute(42, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.LastName

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.LastName = __value, newGuardian.LastName))));
                        __builder4.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.LastName));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_1(__builder4, 47, 48, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.LastName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(49, "\r\n\r\n            \r\n            ");
                        __builder4.OpenElement(50, "div");
                        __builder4.AddAttribute(51, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(52, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"location\">\r\n                    Location\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(53);
                        __builder4.AddAttribute(54, "id", "middleName");
                        __builder4.AddAttribute(55, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.Location

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.Location = __value, newGuardian.Location))));
                        __builder4.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.Location));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_2(__builder4, 60, 61, 
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.Location

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(62, "\r\n\r\n            ");
                        __builder4.OpenElement(63, "div");
                        __builder4.AddAttribute(64, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(65, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"mainphone\">\r\n                    Main Phone Number\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                        __builder4.AddAttribute(67, "id", "mainphone");
                        __builder4.AddAttribute(68, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.MainPhone

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.MainPhone = __value, newGuardian.MainPhone))));
                        __builder4.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.MainPhone));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_3(__builder4, 73, 74, 
#nullable restore
#line 63 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.MainPhone

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(75, "\r\n            \r\n            ");
                        __builder4.OpenElement(76, "div");
                        __builder4.AddAttribute(77, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(78, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone1\">\r\n                    Alternative Phone Number 1\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(79);
                        __builder4.AddAttribute(80, "id", "altphone1");
                        __builder4.AddAttribute(81, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(82, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.AltPhone1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.AltPhone1 = __value, newGuardian.AltPhone1))));
                        __builder4.AddAttribute(84, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.AltPhone1));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(85, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_4(__builder4, 86, 87, 
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.AltPhone1

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(88, "\r\n            \r\n            ");
                        __builder4.OpenElement(89, "div");
                        __builder4.AddAttribute(90, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(91, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone2\">\r\n                    Alternative Phone Number 2\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(92);
                        __builder4.AddAttribute(93, "id", "altphone2");
                        __builder4.AddAttribute(94, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 80 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.AltPhone2

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.AltPhone2 = __value, newGuardian.AltPhone2))));
                        __builder4.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.AltPhone2));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(98, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_5(__builder4, 99, 100, 
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.AltPhone2

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(101, "\r\n            \r\n            ");
                        __builder4.OpenElement(102, "div");
                        __builder4.AddAttribute(103, "class", "w-full px-3 mb-6");
                        __builder4.AddMarkupContent(104, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone3\">\r\n                    Alternative Phone Number 3\r\n                </label>\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(105);
                        __builder4.AddAttribute(106, "id", "altphone3");
                        __builder4.AddAttribute(107, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                        __builder4.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                        newGuardian.AltPhone3

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newGuardian.AltPhone3 = __value, newGuardian.AltPhone3))));
                        __builder4.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newGuardian.AltPhone3));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(111, "\r\n                ");
                        __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation.TypeInference.CreateValidationMessage_6(__builder4, 112, 113, 
#nullable restore
#line 90 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                          () => newGuardian.AltPhone3

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(114, "\r\n            \r\n            \r\n            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(115);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(117);
                    __builder3.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(119, "div");
                        __builder4.AddAttribute(120, "class", "create-button-container");
                        __builder4.OpenComponent<MudBlazor.MudButton>(121);
                        __builder4.AddAttribute(122, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 99 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(123, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 100 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                  Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(124, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 101 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                 Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(125, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 102 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                       Icons.Material.Add

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(126, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 103 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(128, "\r\n                    Add New Guardian\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianCreation.razor"
       

    private GuardianCreationModel newGuardian = new();
    
    // private RenderFragment DynamicRender { get; set; }
    //
    // private RenderFragment CreateComponent() => builder =>
    // {
    //     builder.OpenComponent(0, typeof(TextBox));
    //     builder.AddAttribute(1, "Title", "Enter your text");
    //     builder.CloseComponent();
    // };

    private async Task HandleValidSubmit()
    {
        await guardianRepository.AddGuardianAsync(newGuardian);
        toaster.Add("Guardian added.", MatToastType.Success);
        navigationManager.NavigateTo("/guardians");
    }

    private void OnCancel()
    {
        navigationManager.NavigateTo("/guardians");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGuardianRepository guardianRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.LCMClient.Features.Guardians.Components.GuardianCreation
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
