#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fec4e2c3ead3c17f171ade45fb0d63167c2d437"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Features.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Features.Orphans.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Features.Orphans.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Features.Shared.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
using LCMClient.Helpers;

#line default
#line hidden
#nullable disable
    public partial class GuardianAssignmentDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(0);
            __builder.AddAttribute(1, "Width", "500px");
            __builder.AddAttribute(2, "IsModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsVisible = __value, IsVisible))));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogEvents>(7);
                __builder2.AddAttribute(8, "Opened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Popups.OpenEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Popups.OpenEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                          Opened

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(10);
                __builder2.AddAttribute(11, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "<h3 class=\"text-3xl font-semibold\">Assign Guardian to Orphan</h3>");
                }
                ));
                __builder2.AddAttribute(13, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(14, "div");
                    __builder3.AddAttribute(15, "class", "w-full m-6 text-gray-600 text-xl");
                    __builder3.AddMarkupContent(16, "\r\n                Assign Guardian to <br>");
                    __builder3.AddContent(17, 
#nullable restore
#line 21 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                        Orphan.FullName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(18, "\r\n            ");
                    __builder3.OpenElement(19, "div");
                    __builder3.AddAttribute(20, "class", "w-11/12 m-6 mr-6");
#nullable restore
#line 24 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                 if (gotData)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.SfAutoComplete<string, GuardianModel>>(21);
                    __builder3.AddAttribute(22, "Placeholder", "Select Guardian (start typing guardian\'s name)");
                    __builder3.AddAttribute(23, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<GuardianModel>>(
#nullable restore
#line 31 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                 guardians

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "PopupHeight", "400px");
                    __builder3.AddAttribute(25, "PopupWidth", "380px");
                    __builder3.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 29 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                  selectedValue

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedValue = __value, selectedValue))));
                    __builder3.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => selectedValue));
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.AutoCompleteFieldSettings>(30);
                        __builder4.AddAttribute(31, "Value", "NameAndLocation");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(32, (__value) => {
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                          sfAutoComplete = (Syncfusion.Blazor.DropDowns.SfAutoComplete<string, GuardianModel>)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.OpenElement(33, "div");
                    __builder3.AddAttribute(34, "class", "mt-6");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, string>>(35);
                    __builder3.AddAttribute(36, "Placeholder", "Relationship to Orphan");
                    __builder3.AddAttribute(37, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<string>>(
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                     relationships

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                      relationshipSelected

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => relationshipSelected = __value, relationshipSelected))));
                    __builder3.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => relationshipSelected));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string, string>>(42);
                        __builder4.AddAttribute(43, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string, string>>(this, 
#nullable restore
#line 47 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                             OnDropdownValueChanged

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 51 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"

                    if (otherSelected)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "mt-6");
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(46);
                    __builder3.AddAttribute(47, "ID", "sfTextBox");
                    __builder3.AddAttribute(48, "CssClass", "e-outline");
                    __builder3.AddAttribute(49, "Placeholder", "Relationship to Orphan");
                    __builder3.AddAttribute(50, "FloatLabelType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.FloatLabelType>(
#nullable restore
#line 59 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                        FloatLabelType.Auto

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "Created", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Object>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Object>(this, 
#nullable restore
#line 61 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                OnCreated

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 60 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                    relationship

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => relationship = __value, relationship))));
                    __builder3.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => relationship));
                    __builder3.AddComponentReferenceCapture(55, (__value) => {
#nullable restore
#line 56 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                             sfTextBox = (Syncfusion.Blazor.Inputs.SfTextBox)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
#nullable restore
#line 64 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(56, "div");
                    __builder3.AddAttribute(57, "class", "text-center h-40");
                    __builder3.OpenComponent<LCMClient.Shared.LoadingAnimation>(58);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n                        ");
                    __builder3.AddMarkupContent(60, "<p>Loading...</p>");
                    __builder3.CloseElement();
#nullable restore
#line 72 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"

                }

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogButtons>(62);
                __builder2.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(64);
                    __builder3.AddAttribute(65, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                HandleValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(67);
                        __builder4.AddAttribute(68, "Content", "Save");
                        __builder4.AddAttribute(69, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 81 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                                         true

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Popups.DialogButton>(71);
                    __builder3.AddAttribute(72, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
                                OnCancelBtnClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(73, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Syncfusion.Blazor.Popups.DialogButtonModel>(74);
                        __builder4.AddAttribute(75, "Content", "Cancel");
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
            __builder.AddMarkupContent(76, "\r\n\r\n");
            __builder.AddMarkupContent(77, @"<style>
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
#line 103 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\GuardianAssignmentDialog.razor"
       

    private string[] relationships = { "Mother", "Father", "Sister", "Brother", "Aunt", "Uncle", "Cousin (female)", "Cousin (male)", "Grandmother", "Grandfather", "Stepsister", "Stepbrother", "Stepmother", "Stepfather", "Sister-in-law", "Brother-in-law", "Friend", "Other" };

    private bool gotData = false;

    private string relationshipSelected = "";

    private string relationship = "";

    private bool otherSelected = false;

    private SfAutoComplete<string, GuardianModel> sfAutoComplete;

    private SfTextBox sfTextBox;

    protected override async Task OnInitializedAsync()
    {
        guardians = await GuardianRepository.GetGuardiansAsync();
        foreach (var guardian in guardians)
        {
            guardian.NameAndLocation = $"{ guardian.FullName } ({ guardian.Location })";
        }

        gotData = guardians != null;
    }

    private List<GuardianModel> guardians;

    private string selectedValue = string.Empty;

    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public EventCallback<bool> OnAddNewComplete { get; set; }

    [Inject]
    public IGuardianRepository GuardianRepository { get; set; }

    [Inject]
    public IOrphanRepository OrphanRepository { get; set; }


    [Inject]
    protected IMatToaster Toaster { get; set; }


    private async Task HandleValidSubmit()
    {
        if (Orphan == null)
        {
            Toaster.Add($" No Orphan record found.", MatToastType.Danger);
            return;
        }

        var selectedGuardian = guardians.FirstOrDefault(g => g.NameAndLocation.Equals(selectedValue));

        if (selectedGuardian == null)
        {
            Toaster.Add($" No Guardian selected.", MatToastType.Danger);
            return;
        }

        await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "guardianID", selectedGuardian.GuardianID.ToString());

        // User can select "Other" from dropdown then type more specific relationship in text box
        if (!"Other".Equals(relationshipSelected))
        {
            relationship = relationshipSelected;
        }

        if (!string.IsNullOrWhiteSpace(relationship))
            await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "relationshipToGuardian", relationship);


        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(true);
        StateHasChanged();
        Toaster.Add($" Successful assignment.", MatToastType.Success);
    }

    private void OnDropdownValueChanged()
    {
        // relationship.Equals(...) locked up the UI
        otherSelected = "Other".Equals(relationshipSelected);
        relationship = relationshipSelected;
    }

    private void OnCreated()
    {
        sfTextBox.FocusIn();
    }

    async Task Opened(Syncfusion.Blazor.Popups.OpenEventArgs args)
    {
        await sfAutoComplete.FocusIn();
    }

    private async Task OnCancelBtnClick()
    {
        IsVisible = false;
        await OnAddNewComplete.InvokeAsync(false);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
