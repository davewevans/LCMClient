#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6332b8b38a0096325a7b745ee5e7b79f57c06c31"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using LCMClient.Features.Orphans.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using LCMClient.Features.Orphans.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
    public partial class SponsorAssignmentDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "500px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(7);
                __builder2.AddAttribute(8, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(9, "<h3 class=\"text-3xl font-semibold\">Assign Sponsor to Orphan</h3>");
                }
                ));
                __builder2.AddAttribute(10, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "w-full m-6 text-gray-600 text-xl");
                    __builder3.AddMarkupContent(13, "\r\n                Assign Sponsor to <br>");
                    __builder3.AddContent(14, 
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                       Orphan.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(15, "\r\n            ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "w-11/12 m-6 mr-6");
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                 if (gotData)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.SfAutoComplete<string, SponsorModel>>(18);
                    __builder3.AddAttribute(19, "Placeholder", "Select Sponsor");
                    __builder3.AddAttribute(20, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SponsorModel>>(
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                                 sponsors

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "PopupHeight", "400px");
                    __builder3.AddAttribute(22, "PopupWidth", "400px");
                    __builder3.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 23 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                                 selectedSponsor

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedSponsor = __value, selectedSponsor))));
                    __builder3.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => selectedSponsor));
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteTemplates<SponsorModel>>(27);
                        __builder4.AddAttribute(28, "ItemTemplate", (Microsoft.AspNetCore.Components.RenderFragment<SponsorModel>)((context) => (__builder5) => {
                            __builder5.OpenElement(29, "div");
                            __builder5.AddAttribute(30, "class", "flex font-semibold mb-1");
                            __builder5.OpenElement(31, "p");
                            __builder5.AddContent(32, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).FirstName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(33, "\r\n                                    ");
                            __builder5.OpenElement(34, "p");
                            __builder5.AddContent(35, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).LastName

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(36, "\r\n                                ");
                            __builder5.OpenElement(37, "div");
                            __builder5.AddAttribute(38, "class", "m-b1");
                            __builder5.OpenElement(39, "p");
                            __builder5.AddContent(40, 
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).Email

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(41, "\r\n                                    ");
                            __builder5.OpenElement(42, "p");
                            __builder5.AddContent(43, 
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).MainPhone

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(44, "\r\n                                ");
                            __builder5.OpenElement(45, "div");
                            __builder5.AddAttribute(46, "class");
                            __builder5.OpenElement(47, "p");
                            __builder5.AddContent(48, 
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).Address

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(49, "\r\n                                ");
                            __builder5.OpenElement(50, "div");
                            __builder5.AddAttribute(51, "class", "flex");
                            __builder5.OpenElement(52, "p");
                            __builder5.AddContent(53, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).City

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddContent(54, ",");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(55, "\r\n                                    ");
                            __builder5.OpenElement(56, "p");
                            __builder5.AddContent(57, 
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).State

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(58, "\r\n                                    ");
                            __builder5.OpenElement(59, "p");
                            __builder5.AddContent(60, 
#nullable restore
#line 46 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                         (context as SponsorModel).ZipCode

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(61, "\r\n                                <div class=\"border-b-2 border-blue-900 mb-2\"></div>");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(62, "\r\n                        ");
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteFieldSettings>(63);
                        __builder4.AddAttribute(64, "Value", "FullName");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(65, (__value) => {
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                          autoCompleteObj = (Syncfusion.Blazor.DropDowns.SfAutoComplete<string, SponsorModel>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"

                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(66, "div");
                    __builder3.AddAttribute(67, "class", "text-center h-40");
                    __builder3.OpenComponent<LCMClient.Shared.LoadingAnimation>(68);
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(70);
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(72);
                    __builder3.AddAttribute(73, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(75);
                        __builder4.AddAttribute(76, "Content", "Save");
                        __builder4.AddAttribute(77, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(79);
                    __builder3.AddAttribute(80, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
                                OnCancelBtnClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(82);
                        __builder4.AddAttribute(83, "Content", "Cancel");
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
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.AddMarkupContent(85, @"<style>
    .e-btn.e-flat.e-primary, .e-btn.e-flat.e-primary:focus {
        background-color: #317ab9;
        border-color: #265f91;
        color: #fff;
    }

        .e-btn.e-flat.e-primary:hover, .e-btn.e-flat.e-primary:active {
            background-color: #21527d;
            border-color: #163854;
            color: #fff;
        }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\SponsorAssignmentDialog.razor"
       

    public SfAutoComplete<string, SponsorModel> autoCompleteObj;

    private bool gotData = false;

    protected override async Task OnInitializedAsync()
    {
        sponsors = await SponsorRepository.GetSponsorsAsync();

        if (sponsors != null)
        {
            foreach (var sponsor in sponsors)
            {
                sponsor.FullName = $"{sponsor.FirstName} {sponsor.LastName} ({sponsor.Email})";
            }
        }

        gotData = sponsors != null && sponsors.Any();
    }

    private List<SponsorModel> sponsors;

    private string selectedSponsor;

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public EventCallback<bool> OnAddNewComplete { get; set; }

    [Inject]
    public ISponsorRepository SponsorRepository { get; set; }

    [Inject]
    public IOrphanSponsorRepository OrphanSponsorRepository { get; set; }

    [Inject]
    public IOrphanRepository OrphanRepository { get; set; }


    [Inject]
    protected IMatToaster Toaster { get; set; }


    private async Task HandleValidSubmit()
    {
        if (Orphan == null)
        {
            Toaster.Add($" No Sponsor record found.", MatToastType.Danger);
            return;
        }

        var sponsor = sponsors.FirstOrDefault(s => s.FullName == selectedSponsor);

        if (sponsor != null)
        {
            var orphanSponsor = new OrphanSponsorModel
            {
                OrphanID = Orphan.OrphanID,
                SponsorID = sponsor.SponsorID
            };
            await OrphanSponsorRepository.AddAssignment(orphanSponsor);
            IsVisible = false;
            await OnAddNewComplete.InvokeAsync(true);
            StateHasChanged();
            Toaster.Add($" Successful assignment.", MatToastType.Success);
        }

    }

    private async Task OnCancelBtnClick()
    {
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(false);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591