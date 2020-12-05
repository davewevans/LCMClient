using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Services;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository
{
    public class PictureRepository : IPictureRepository
    {
        private readonly IHttpService httpService;
        private readonly HttpClient httpClient;

        private const string Controller = "pictures";
        private readonly string url = "";

        public PictureRepository(IHttpService httpService, HttpClient httpClient)
        {
            this.httpService = httpService;
            this.httpClient = httpClient;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }

        public async Task<string> UploadImageAsync(PictureCreationModel picCreation, byte[] fileBytes)
        {   
            await using MemoryStream fileStream = new MemoryStream(fileBytes);

            // Create the content
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");

            var fileStreamContent = new StreamContent(fileStream, (int)fileStream.Length);

            // Set the content type
            var headerValueContentType = new MediaTypeHeaderValue(picCreation.ContentType);           
            fileStreamContent.Headers.ContentType = headerValueContentType;

            content.Add(new StringContent(picCreation.Caption ?? string.Empty), "Caption");
            content.Add(new StringContent(picCreation.OrphanID.ToString()), "OrphanID");
            content.Add(fileStreamContent, "file", picCreation.PictureFileName);

            string apiActionUrl = picCreation.IsProfilePic ? $"{ url }/uploadProfilePicture" : $"{ url }/uploadPicture";

            var response = await httpService.PostForm(apiActionUrl, content);

            if (!response.Success)
            {
                // TODO throws 404 exception in browser
                //throw new ApplicationException(await response.GetBody());
            }
            return await response.HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
}
