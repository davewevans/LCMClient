#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfdbe3ba18ad7ecc98f50c7f50f94c41d7ae59b1"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
using LCMClient.Services;

#line default
#line hidden
#nullable disable
    public partial class GuardiansDataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
 if(readyForGrid)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<GuardianModel>>(0);
            __builder.AddAttribute(1, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                        false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Query", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Data.Query>(
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                Qry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Toolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                  ToolbarItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowReordering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "AllowResizing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowTextWrap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "AllowExcelExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowPdfExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(13);
                __builder2.AddAttribute(14, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                              Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(16);
                __builder2.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                 pageSize

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                  PageSizes

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(20);
                __builder2.AddAttribute(21, "EnableToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "EnableSimpleMultiRowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                              false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<GuardianModel>>(24);
                __builder2.AddAttribute(25, "OnLoad", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                        Load

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                ToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "OnRecordClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.RecordClickEventArgs<GuardianModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.RecordClickEventArgs<GuardianModel>>(this, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                               RecordClickHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<GuardianModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<GuardianModel>>(this, 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                               ActionBeginHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(30);
                __builder2.AddAttribute(31, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                         apiUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "CrossDomain", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            Adaptors.WebApiAdaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(35);
                __builder2.AddAttribute(36, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                    false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                     false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            EditMode.Normal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowEditOnDblClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                           false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ShowDeleteConfirmDialog", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(45);
                    __builder3.AddAttribute(46, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            nameof(GuardianModel.GuardianID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            nameof(GuardianModel.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "First Name");
                    __builder3.AddAttribute(54, "Width", "120");
                    __builder3.AddAttribute(55, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 56 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                       new ValidationRules {Required = true, MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(57);
                    __builder3.AddAttribute(58, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            nameof(GuardianModel.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "HeaderText", "Last Name");
                    __builder3.AddAttribute(60, "Width", "120");
                    __builder3.AddAttribute(61, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                       new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(63);
                    __builder3.AddAttribute(64, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            nameof(GuardianModel.Location)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "HeaderText", "Location");
                    __builder3.AddAttribute(66, "Width", "160");
                    __builder3.AddAttribute(67, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                       new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(69);
                    __builder3.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                            nameof(GuardianModel.NumberOfDependents)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "HeaderText", "Dependents");
                    __builder3.AddAttribute(72, "Width", "160");
                    __builder3.AddAttribute(73, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 68 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                       new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(74, "\r\n\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(75);
                    __builder3.AddAttribute(76, "HeaderText", "");
                    __builder3.AddAttribute(77, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                             Syncfusion.Blazor.Grids.TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(78, "Width", "80");
                    __builder3.AddAttribute(79, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(80, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                  
                    var _guardian = (context as GuardianModel);

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(81);
                        __builder4.AddAttribute(82, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                        ProfileBtnContent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(83, "CssClass", "e-link");
                        __builder4.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
                                                                                         () => NavigateToDetails(_guardian.GuardianID)

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
            __builder.AddComponentReferenceCapture(85, (__value) => {
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
              GuardianDataGrid = (Syncfusion.Blazor.Grids.SfGrid<GuardianModel>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "<p>Loading...</p>");
#nullable restore
#line 85 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Guardians\Components\GuardiansDataGrid.razor"
       

    private bool readyForGrid = false;

    private string apiUrl = "";

    private SfGrid<GuardianModel> GuardianDataGrid = new SfGrid<GuardianModel>();

    public static string searchTerm = "";
    public Query Qry = new Query();
    private string ProfileBtnContent = "View/Edit";

    public List<GuardianModel> Guardians { get; set; }

    public List<string> ToolbarItems = new List<string> { "ExcelExport", "PdfExport", "Search" };

    public int[] PageSizes = { 5, 10, 20, 50, 100 };
    private int pageSize = 20;

    protected override void OnInitialized()
    {
        readyForGrid = false;
        apiUrl = $"{ httpService.BaseUrl }guardians/guardiansSFDataGrid";
        readyForGrid = true;
    }

    public async Task ActionBeginHandler(ActionEventArgs<GuardianModel> args)
    {
        // Add to query string parameters for search and sorting
        if (string.IsNullOrWhiteSpace(args.SearchString)) await GuardianDataGrid.Search("");
        Qry.AddParams("SearchTerm", args.SearchString);

        if (!string.IsNullOrWhiteSpace(args.ColumnName))
            Qry.AddParams("ColumnName", args.ColumnName);

        Qry.AddParams("SortDirection", args.Direction);
    }

    public async Task ToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id.Contains("excelexport"))
        {
            await this.GuardianDataGrid.ExcelExport();
        }

        if (args.Item.Id.Contains("pdfexport"))
        {
            await this.GuardianDataGrid.PdfExport();
        }
    }

    private void NavigateToDetails(int id)
    {
        navigationManager.NavigateTo($"/GuardianDetails/{ id }");
    }

    public void RecordClickHandler(RecordClickEventArgs<GuardianModel> args)
    {
        navigationManager.NavigateTo($"/GuardianDetails/{ args.RowData.GuardianID }");
    }

    public void Load(object args)
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpService httpService { get; set; }
    }
}
#pragma warning restore 1591
