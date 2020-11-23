#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6058291e89f2192fd4f0fc9141bf9dcef4f20a70"
// <auto-generated/>
#pragma warning disable 1591
namespace LCMClient.Features.Admin
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
using LCMClient.Respository;

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
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
using LCMClient.Features.Admin.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/resetPassword/{userId}")]
    public partial class ResetPassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mb-16");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                     passwordResetDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                      ResetPasswordHandler

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudCard>(8);
                __builder2.AddAttribute(9, "Class", "my-mud-card-form");
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(11);
                    __builder3.AddAttribute(12, "Style", "background-color:lightskyblue;");
                    __builder3.AddAttribute(13, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(14);
                        __builder4.AddAttribute(15, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 22 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                   Typo.h6

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(17, "Reset Password");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(18, "CardHeaderActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIconButton>(19);
                        __builder4.AddAttribute(20, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                          Icons.Material.Cancel

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(21, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                                        Color.Default

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                                                                 OnCancel

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCardContent>(24);
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 31 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                 if (user != null)
                {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(26, "div");
                        __builder4.AddAttribute(27, "class", "font-semibold text-xl");
                        __builder4.AddContent(28, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                         user?.FirstName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.AddContent(29, " ");
                        __builder4.AddContent(30, 
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                          user?.LastName

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                        __builder4.OpenElement(31, "div");
                        __builder4.AddAttribute(32, "class", "font-semibold text-xl mb-6");
                        __builder4.AddContent(33, 
#nullable restore
#line 38 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                         user?.Email

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                }

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<MudBlazor.MudGrid>(34);
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudItem>(36);
                            __builder5.AddAttribute(37, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                 12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __Blazor.LCMClient.Features.Admin.ResetPassword.TypeInference.CreateMudTextField_0(__builder6, 39, 40, "New Password", 41, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                                                                               Variant.Text

#line default
#line hidden
#nullable disable
                                , 42, 
#nullable restore
#line 44 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                   passwordResetDTO.NewPassword

#line default
#line hidden
#nullable disable
                                , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => passwordResetDTO.NewPassword = __value, passwordResetDTO.NewPassword)));
                                __builder6.AddMarkupContent(44, "\r\n                        ");
                                __Blazor.LCMClient.Features.Admin.ResetPassword.TypeInference.CreateValidationMessage_1(__builder6, 45, 46, 
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                  () => passwordResetDTO.NewPassword

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(47, "\r\n\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudItem>(48);
                            __builder5.AddAttribute(49, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 48 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                 12

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __Blazor.LCMClient.Features.Admin.ResetPassword.TypeInference.CreateMudTextField_2(__builder6, 51, 52, "Confirm Password", 53, 
#nullable restore
#line 49 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                                                                                       Variant.Text

#line default
#line hidden
#nullable disable
                                , 54, 
#nullable restore
#line 49 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                   passwordResetDTO.ConfirmPassword

#line default
#line hidden
#nullable disable
                                , 55, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => passwordResetDTO.ConfirmPassword = __value, passwordResetDTO.ConfirmPassword)));
                                __builder6.AddMarkupContent(56, "\r\n                        ");
                                __Blazor.LCMClient.Features.Admin.ResetPassword.TypeInference.CreateValidationMessage_3(__builder6, 57, 58, 
#nullable restore
#line 50 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                                  () => passwordResetDTO.ConfirmPassword

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudCardActions>(60);
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudButton>(62);
                        __builder4.AddAttribute(63, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 56 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                    Variant.Filled

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(64, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 57 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(65, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 58 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                 Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 59 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
                                  Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(67, "Style", "margin-left:auto;margin-right:auto;");
                        __builder4.AddAttribute(68, "Class", "mt-6");
                        __builder4.AddAttribute(69, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(70, "\r\n                    Reset Password\r\n                ");
                        }
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
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Admin\ResetPassword.razor"
       

    [Parameter]
    public string UserId { get; set; }

    private UserDTO user { get; set; }

    private PasswordResetDTO passwordResetDTO = new PasswordResetDTO();

    protected override async Task OnInitializedAsync()
    {
        user = await userRepository.GetUserById(UserId);
    }

    private async Task ResetPasswordHandler()
    {
        var result = await accountsRepository.ResetPassword(UserId, passwordResetDTO);
        if (result)
        {
            ShowSnackbar("Password reset successfully.", MatToastType.Success);
            navigationManager.NavigateTo("/admin");
            return;
        }
        ShowSnackbar("Password reset failed.", MatToastType.Danger);

    }

    private void ShowSnackbar(string message, MatToastType type)
    {
        Toaster.Add(message, type, "", "", config =>
        {
            config.ShowProgressBar = false;
            config.RequireInteraction = false;
        });
    }

    private void OnCancel()
    {
        navigationManager.NavigateTo("/admin");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserRepository userRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster Toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountsRepository accountsRepository { get; set; }
    }
}
namespace __Blazor.LCMClient.Features.Admin.ResetPassword
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591