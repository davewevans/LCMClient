#pragma checksum "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf59775f6698b50787fbcf5d46d11c27a1d9daf0"
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
#line 1 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
using LCMClient.Features.Orphans.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
using LCMClient.Features.Orphans.Repository.Contracts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
using Syncfusion.Blazor.ProgressBar;

#line default
#line hidden
#nullable disable
    public partial class OrphanPDFUpload : Microsoft.AspNetCore.Components.ComponentBase
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
#line 14 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                       HandleFileUpload

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "cursor-pointer relative block opacity-0 w-full h-full p-20 z-50");
            __builder.AddElementReferenceCapture(6, (__value) => {
#nullable restore
#line 13 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                 inputReference = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<div class=\"text-center p-10 absolute top-0 right-0 left-0 m-auto\"><h4>\r\n            Drop an PDF file in this box to upload\r\n            <br>or\r\n        </h4>\r\n        <p class=\"text-xl\">Click to Select a PDF</p></div>");
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
 if (progress < 100)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.ProgressBar.SfProgressBar>(9);
            __builder.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                           progress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Minimum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                                              0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "Maximum", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                                                          100

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "TrackThickness", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                                                                               12

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ProgressThickness", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 28 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                                                                                                      12

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
               statusClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, 
#nullable restore
#line 33 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                             status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
 if (uploadFailed)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "class", 
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
               statusClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, 
#nullable restore
#line 39 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
                             status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\davew\OneDrive\Documents\GitHub\LCMClient\LCMClient\Features\Orphans\Components\OrphanPDFUpload.razor"
       

    [Parameter]
    public OrphanDetailsModel Orphan { get; set; }

    [Parameter]
    public int? SponsorID { get; set; }

    [Parameter]
    public bool AllSponsors { get; set; }

    [Parameter]
    public EventCallback<OrphanDetailsModel> HandlePostUpload { get; set; }

    string status = "";
    string statusClass = "";
    bool uploadFailed = false;
    int maxFileSizeMb = 50 * 1024 * 1024;
    private double progress = 0;
    private string progressWidth => $"{progress}%";

    readonly string[] allowedContentTypes = { "application/pdf", "application/x-pdf" };

    ElementReference inputReference;

    private async Task HandleFileUpload()
    {
        progress = 0;
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
                        progress = (((double)countSize / fileInfo.Size) * 97);
                        StateHasChanged();
                    }

                    fileBytes = ms.ToArray();
                }
            }


            if (SponsorID is null && !AllSponsors)
            {
                status = "No sponsor selected.";
                statusClass = "text-red-600 text-2xl";
                return;
            }


            var pdfCreation = new PDFCreationModel
            {
                FileName = fileInfo.Name,
                ContentType = fileInfo.Type,
                OrphanID = Orphan.OrphanID,
                AllSponsors = AllSponsors,
                OriginalFileName = fileInfo.Name,
                SponsorID = SponsorID == 0 ? null : SponsorID
            };


            bool result = await PdfRepository.UploadPDFAsync(pdfCreation, fileBytes);

            await HandlePostUpload.InvokeAsync(Orphan);
            ShowResult(result);

        }
    }

    private void ShowResult(bool isSuccess)
    {
        if (isSuccess)
        {
            progress = 100;
            status = "Upload Success!";
            statusClass = "text-green-600 text-2xl";
            toaster.Add("Successfully uploaded!.", MatToastType.Success);
        }
        else
        {
            status = "Something went wrong :(";
            statusClass = "text-red-600 text-2xl";
            uploadFailed = true;
            toaster.Add("Upload failed.", MatToastType.Danger);
        }
    }

    private bool IsValidFile(string type, long size)
    {
        if (!allowedContentTypes.Contains(type))
        {
            uploadFailed = true;
            status = "Please select a .pdf file.";
            statusClass = "text-red-600 text-2xl";
            return false;
        }

        if (size > maxFileSizeMb)
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMatToaster toaster { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPDFRepository PdfRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService FileReader { get; set; }
    }
}
#pragma warning restore 1591
