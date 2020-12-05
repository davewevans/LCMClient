using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Services;

namespace LCMClient.Features.Orphans.Repository
{
    public class PDFRepository : IPDFRepository
    {
        private readonly IHttpService httpService;
        private readonly HttpClient httpClient;

        private const string Controller = "documents";
        private readonly string url = "";

        public PDFRepository(IHttpService httpService, HttpClient httpClient)
        {
            this.httpService = httpService;
            this.httpClient = httpClient;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }
        
        public async Task<string> UploadPDFAsync(PDFCreationModel pdfCreation, byte[] fileBytes)
        {
            await using MemoryStream fileStream = new MemoryStream(fileBytes);

            // Create the content
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");

            var fileStreamContent = new StreamContent(fileStream, (int)fileStream.Length);

            // Set the content type
            var headerValueContentType = new MediaTypeHeaderValue(pdfCreation.ContentType);
            fileStreamContent.Headers.ContentType = headerValueContentType;

            //var jsonData = JsonSerializer.Serialize<PDFCreationModel>(pdfCreation, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            //content.Add(new StringContent(jsonData, Encoding.UTF8, "application/json"));

            content.Add(new StringContent(pdfCreation.OrphanID.ToString()), "OrphanID");
            content.Add(new StringContent(pdfCreation.SponsorID.ToString()), "SponsorID");
            content.Add(new StringContent(pdfCreation.AllSponsors.ToString()), "AllSponsors");

            content.Add(fileStreamContent, "file", pdfCreation.FileName);

            string apiActionUrl =  $"{ url }/uploadPDF";

            var response = await httpService.PostForm(apiActionUrl, content);

            if (!response.Success)
            {
                // TODO throws 404 exception in browser
                //throw new ApplicationException(await response.GetBody());
            }
            return await response.HttpResponseMessage.Content.ReadAsStringAsync();


            //
            // TODO use http service instead
            // not working for now; need to figure out why
            //
            //var response = await httpClient.PostAsync(url, content);
            // var response = await httpService.Post(url, content);

            //if (!response.IsSuccessStatusCode)
            //{
            //    return null;
            //}

            //return await response.Content.ReadAsStringAsync();
        }

        public async Task<List<PDFModel>> GetOrphanPDFsAsync(int orphanId)
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await httpService.Get<List<PDFModel>>($"{ url }/pdfs/{ orphanId }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task DeletePDFAsync(int pdfID)
        {
            var response = await httpService.Delete($"{ url }/{ pdfID }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}