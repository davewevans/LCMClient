#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786996030f82255a9060d85fa820cf67ec45ce6f"
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
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
using LCMClient.Features.Orphans.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
using LCMClient.Features.Orphans.Models;

#line default
#line hidden
#nullable disable
    public partial class OrphanPhotoUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border border-dashed border-gray-500 relative");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "file");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                       HandleFileUpload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "cursor-pointer relative block opacity-0 w-full h-full p-20 z-50");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 12 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                 inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div class=\"text-center p-10 absolute top-0 right-0 left-0 m-auto\"><h4>\r\n            Drop an image file in this box to upload\r\n            <br>or\r\n        </h4>\r\n        <p class=\"text-xl\">Click to Select a Photo</p></div>");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
 if (progress.HasValue)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
     if (progress < 100)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "shadow w-full bg-grey-light");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "bg-blue text-xs leading-none py-1 text-center text-white");
            __builder.AddAttribute(13, "style", "width:" + " " + (
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                                                                                                 progress

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddContent(14, 
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                                                                                                             progress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, "%");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                   statusClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(18, 
#nullable restore
#line 35 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                                 status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
 if (uploadFailed)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", 
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
               statusClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, 
#nullable restore
#line 41 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
                             status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPhotoUpload.razor"
       

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public bool IsProfilePhoto { get; set; }

    [Parameter]
    public EventCallback<OrphanDetailsModel> HandlePostUpload { get; set; }

    string status = "";
    string statusClass = "";
    bool uploadFailed = false;
    int maxFileSizeMb = 10;

    readonly string[] allowedContentTypes = { "image/jpeg", "image/png", "image/gif" };

    ElementReference inputReference;

    private int? progress;

    private async Task HandleFileUpload()
    {
        int countSize = 0;
        uploadFailed = false;
        status = "";

        // Read the file
        var file = (await FileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();

        if (file != null)
        {
            var fileInfo = await file.ReadFileInfoAsync();

            if (!IsValidFile(fileInfo.Type, fileInfo.Size)) return;

            byte[] fileBytes;
            await using (var ms = new MemoryStream())
            {
                await using (var fs = await file.OpenReadAsync())
                {
                    var bufferSize = 4096;
                    var buffer = new byte[bufferSize];
                    int count;
                    while ((count = await fs.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        ms.Write(buffer, 0, count);
                        countSize += count;
                        progress = (int)(((decimal)countSize / fileInfo.Size) * 97);
                        StateHasChanged();
                    }

                    fileBytes = ms.ToArray();
                }
            }

            var picCreation = new PictureCreationModel
            {
                PictureFileName = fileInfo.Name,
                IsProfilePic = IsProfilePhoto,
                ContentType = fileInfo.Type,
                OrphanID = Orphan.OrphanID
            };

            string result = await PicRepository.UploadImageAsync(picCreation, fileBytes);

            if (!string.IsNullOrWhiteSpace(result) && IsProfilePhoto)
            {
                Orphan.ProfilePicUrl = result;
            }
            await HandlePostUpload.InvokeAsync(Orphan);
            ShowStatus(result);
        }
    }

    private void ShowStatus(string result)
    {
        if (string.IsNullOrWhiteSpace(result))
        {
            status = "Something went wrong :(";
            statusClass = "text-red-600 text-2xl";
            uploadFailed = true;
        }
        else
        {
            progress = 100;
            status = "Upload Success!";
            statusClass = "text-green-600 text-2xl";
        }
    }

    private bool IsValidFile(string type, long size)
    {
        if (!allowedContentTypes.Contains(type))
        {
            uploadFailed = true;
            status = "Please select a .png, .jpg, or .gif file.";
            statusClass = "text-red-600 text-2xl";
            return false;
        }

        if (size > maxFileSizeMb * 1024 * 1024)
        {
            uploadFailed = true;
            status = $"Max file size: {maxFileSizeMb}MB";
            statusClass = "text-red-600 text-2xl";
            return false;
        }

        return true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPictureRepository PicRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService FileReader { get; set; }
    }
}
#pragma warning restore 1591
