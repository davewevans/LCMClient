#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b915da5dc9dfb21d71367d6048d6f71d2b02bfe"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
using LCMClient.Features.Guardians.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
           [Authorize(Roles = "Admin,Staff,GuardianReadWrite")]

#line default
#line hidden
#nullable disable
    public partial class GuardianEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<LCMClient.Features.Shared.TabContentHeader>(0);
            __builder.AddAttribute(1, "HeaderText", "Edit");
            __builder.AddAttribute(2, "ShowButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "text-white mt-1");
                __builder2.OpenComponent<MudBlazor.MudIcon>(6);
                __builder2.AddAttribute(7, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                        Icons.Material.Edit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
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
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
 if (guardianToEdit is not null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mt-8 mb-8 ml-32 mr-32");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                          guardianToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                                          HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(19, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"guardianDeceased\">\r\n                    Guardian Deceased\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(20);
                __builder2.AddAttribute(21, "id", "guardianDeceased");
                __builder2.AddAttribute(22, "class", "w-6 h-6");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.IsDeceased

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.IsDeceased = __value, guardianToEdit.IsDeceased))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => guardianToEdit.IsDeceased));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.IsDeceased

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(32, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"firstName\">\r\n                    First Name\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "id", "firstName");
                __builder2.AddAttribute(35, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.FirstName = __value, guardianToEdit.FirstName))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(45, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"lastName\">\r\n                    Last Name\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "lastName");
                __builder2.AddAttribute(48, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.LastName = __value, guardianToEdit.LastName))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_2(__builder2, 53, 54, 
#nullable restore
#line 54 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(58, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"location\">\r\n                    Location\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "middleName");
                __builder2.AddAttribute(61, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.Location = __value, guardianToEdit.Location))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.Location));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.Location

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(71, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"mainphone\">\r\n                    Main Phone Number\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "mainphone");
                __builder2.AddAttribute(74, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(75, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.MainPhone

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(76, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.MainPhone = __value, guardianToEdit.MainPhone))));
                __builder2.AddAttribute(77, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.MainPhone));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_4(__builder2, 79, 80, 
#nullable restore
#line 73 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.MainPhone

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n            ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(84, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone1\">\r\n                    Alternative Phone Number 1\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(85);
                __builder2.AddAttribute(86, "id", "altphone1");
                __builder2.AddAttribute(87, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.AltPhone1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.AltPhone1 = __value, guardianToEdit.AltPhone1))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.AltPhone1));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_5(__builder2, 92, 93, 
#nullable restore
#line 82 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.AltPhone1

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(97, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone2\">\r\n                    Alternative Phone Number 2\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(98);
                __builder2.AddAttribute(99, "id", "altphone2");
                __builder2.AddAttribute(100, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(101, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.AltPhone2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(102, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.AltPhone2 = __value, guardianToEdit.AltPhone2))));
                __builder2.AddAttribute(103, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.AltPhone2));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_6(__builder2, 105, 106, 
#nullable restore
#line 91 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.AltPhone2

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n            ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "w-full px-3 mb-6");
                __builder2.AddMarkupContent(110, "<label class=\"block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2\" for=\"altphone3\">\r\n                    Alternative Phone Number 3\r\n                </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(111);
                __builder2.AddAttribute(112, "id", "altphone3");
                __builder2.AddAttribute(113, "class", "appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500");
                __builder2.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 99 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                        guardianToEdit.AltPhone3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => guardianToEdit.AltPhone3 = __value, guardianToEdit.AltPhone3))));
                __builder2.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => guardianToEdit.AltPhone3));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(117, "\r\n                ");
                __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit.TypeInference.CreateValidationMessage_7(__builder2, 118, 119, 
#nullable restore
#line 100 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                          () => guardianToEdit.AltPhone3

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(121);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n\r\n            ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "d-flex justify-center");
                __builder2.OpenComponent<MudBlazor.MudButton>(125);
                __builder2.AddAttribute(126, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 106 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 107 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                  Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 108 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                 Size.Large

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(129, "StartIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 109 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                       Icons.Material.Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 110 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(132, "\r\n                    Save\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 116 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<LCMClient.Shared.LoadingAnimation>(133);
            __builder.CloseComponent();
#nullable restore
#line 120 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardianEdit.razor"
       

    [Parameter]
    public GuardianDetailsModel GuardianDetails { get; set; }

    [Parameter]
    public EventCallback HandleGuardianEdited { get; set; }

    private GuardianEditModel guardianToEdit;

    protected override void OnParametersSet()
    {
    // Map GuardianDetails obj to new instance of GuardianEditModel
        if (GuardianDetails is null) return;
        guardianToEdit = new GuardianEditModel
        {
            GuardianID = GuardianDetails.GuardianID,
            FirstName = GuardianDetails.FirstName,
            LastName = GuardianDetails.LastName,
            Location = GuardianDetails.Location,
            MainPhone = GuardianDetails.MainPhone,
            AltPhone1 = GuardianDetails.AltPhone1,
            AltPhone2 = GuardianDetails.AltPhone2,
            AltPhone3 = GuardianDetails.AltPhone3,
        };
    }

    private async Task HandleValidSubmit()
    {
        await guardianRepository.UpdateGuardianAsync(guardianToEdit.GuardianID, guardianToEdit);
        await HandleGuardianEdited.InvokeAsync();
        toaster.Add("Guardian updated.", MatToastType.Success);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGuardianRepository guardianRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
namespace __Blazor.LCMClient.Features.Guardians.Components.GuardianEdit
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
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
