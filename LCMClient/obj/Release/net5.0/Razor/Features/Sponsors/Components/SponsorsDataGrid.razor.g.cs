#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f6352fc0165a2b5f4ddc65924b5cd68ea12804"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Sponsors.Components
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
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
using LCMClient.Services;

#line default
#line hidden
#nullable disable
    public partial class SponsorsDataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
 if (readyForGrid)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Grids.SfGrid<SponsorModel>>(0);
            __builder.AddAttribute(1, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Query", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Data.Query>(
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                    Qry

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Toolbar", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                      ToolbarItems

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "AllowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowReordering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "AllowResizing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "AllowTextWrap", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "AllowExcelExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                              true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "AllowPdfExport", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(13);
                __builder2.AddAttribute(14, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                  Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(16);
                __builder2.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                     pageSize

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                      PageSizes

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(20);
                __builder2.AddAttribute(21, "EnableToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "EnableSimpleMultiRowSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                                  false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<SponsorModel>>(24);
                __builder2.AddAttribute(25, "OnLoad", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                            Load

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(26, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                    ToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "OnRecordClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.RecordClickEventArgs<SponsorModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.RecordClickEventArgs<SponsorModel>>(this, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                   RecordClickHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(28, "OnActionBegin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Grids.ActionEventArgs<SponsorModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Grids.ActionEventArgs<SponsorModel>>(this, 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                   ActionBeginHandler

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Data.SfDataManager>(30);
                __builder2.AddAttribute(31, "Url", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                             apiUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "CrossDomain", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "Adaptor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Adaptors>(
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                Adaptors.WebApiAdaptor

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEditSettings>(35);
                __builder2.AddAttribute(36, "AllowAdding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                       false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                        false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "AllowDeleting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                         false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.EditMode>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                EditMode.Normal

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowEditOnDblClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                               false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ShowDeleteConfirmDialog", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                   false

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(43);
                __builder2.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(45);
                    __builder3.AddAttribute(46, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.SponsorID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "IsPrimaryKey", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                                                                  false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.FirstName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "First Name");
                    __builder3.AddAttribute(54, "Width", "80");
                    __builder3.AddAttribute(55, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 56 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {Required = true, MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(56, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(57);
                    __builder3.AddAttribute(58, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.LastName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(59, "HeaderText", "Last Name");
                    __builder3.AddAttribute(60, "Width", "80");
                    __builder3.AddAttribute(61, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(63);
                    __builder3.AddAttribute(64, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.Address)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "HeaderText", "Address");
                    __builder3.AddAttribute(66, "Width", "80");
                    __builder3.AddAttribute(67, "HideAtMedia", "(min-width: 480px)");
                    __builder3.AddAttribute(68, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 65 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(69, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(70);
                    __builder3.AddAttribute(71, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.City)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(72, "HeaderText", "City");
                    __builder3.AddAttribute(73, "Width", "80");
                    __builder3.AddAttribute(74, "HideAtMedia", "(min-width: 480px)");
                    __builder3.AddAttribute(75, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(76, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(77);
                    __builder3.AddAttribute(78, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.State)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(79, "HeaderText", "State");
                    __builder3.AddAttribute(80, "Width", "50");
                    __builder3.AddAttribute(81, "HideAtMedia", "(min-width: 480px)");
                    __builder3.AddAttribute(82, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 75 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 64}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(84);
                    __builder3.AddAttribute(85, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 76 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.ZipCode)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "HeaderText", "Zip Code");
                    __builder3.AddAttribute(87, "Width", "40");
                    __builder3.AddAttribute(88, "HideAtMedia", "(min-width: 480px)");
                    __builder3.AddAttribute(89, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 80 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(91);
                    __builder3.AddAttribute(92, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.Email)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(93, "HeaderText", "Email");
                    __builder3.AddAttribute(94, "Width", "80");
                    __builder3.AddAttribute(95, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 84 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(97);
                    __builder3.AddAttribute(98, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 85 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                nameof(SponsorModel.MainPhone)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(99, "HeaderText", "Phone");
                    __builder3.AddAttribute(100, "Width", "80");
                    __builder3.AddAttribute(101, "ValidationRules", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ValidationRules>(
#nullable restore
#line 88 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                           new ValidationRules {MaxLength = 255}

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(103);
                    __builder3.AddAttribute(104, "HeaderText", "");
                    __builder3.AddAttribute(105, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 89 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                 Syncfusion.Blazor.Grids.TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(106, "Width", "80");
                    __builder3.AddAttribute(107, "AllowEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(108, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 91 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                      
                        var _sponsor = (context as SponsorModel);

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(109);
                        __builder4.AddAttribute(110, "Content", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                            ProfileBtnContent

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(111, "CssClass", "e-link");
                        __builder4.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                                                                                             () => NavigateToDetails(_sponsor.SponsorID)

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
            __builder.AddComponentReferenceCapture(113, (__value) => {
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
                  SponsorDataGrid = (Syncfusion.Blazor.Grids.SfGrid<SponsorModel>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 99 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "<p>Loading...</p>");
#nullable restore
#line 103 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Sponsors\Components\SponsorsDataGrid.razor"
       

    private bool readyForGrid = false;

    private string apiUrl = "";

    private SfGrid<SponsorModel> SponsorDataGrid = new SfGrid<SponsorModel>();

    public static string searchTerm = "";
    public Query Qry = new Query();
    private string ProfileBtnContent = "View/Edit";

    public List<SponsorModel> Sponsors { get; set; }

    public List<string> ToolbarItems = new List<string> { "ExcelExport", "PdfExport", "Search" };

    public int[] PageSizes = { 5, 10, 20, 50, 100 };
    private int pageSize = 20;

    protected override void OnInitialized()
    {
        readyForGrid = false;
        apiUrl = $"{ httpService.BaseUrl }sponsors/sponsorsSFDataGrid";
        readyForGrid = true;
    }

    public async Task ActionBeginHandler(ActionEventArgs<SponsorModel> args)
    {
        // Add to query string parameters for search and sorting
        if (string.IsNullOrWhiteSpace(args.SearchString)) await SponsorDataGrid.Search("");
        Qry.AddParams("SearchTerm", args.SearchString);

        if (!string.IsNullOrWhiteSpace(args.ColumnName))
            Qry.AddParams("ColumnName", args.ColumnName);

        Qry.AddParams("SortDirection", args.Direction);
    }

    public async Task ToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id.Contains("excelexport"))
        {
            await this.SponsorDataGrid.ExcelExport();
        }

        if (args.Item.Id.Contains("pdfexport"))
        {
            await this.SponsorDataGrid.PdfExport();
        }
    }

    private void NavigateToDetails(int id)
    {
        navigationManager.NavigateTo($"/SponsorDetails/{ id }");
    }

    public void RecordClickHandler(RecordClickEventArgs<SponsorModel> args)
    {
        navigationManager.NavigateTo($"/SponsorDetails/{ args.RowData.SponsorID }");
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
