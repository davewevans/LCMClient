using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Shared.Models;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository
{
    public class OrphanRepository : IOrphanRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "orphans";
        private readonly string url = "";

        public OrphanRepository(
            IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }

        public async Task<List<OrphanModel>> GetAllOrphansAsync()
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/allOrphans";
            var response = await httpService.Get<List<OrphanModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        //public async Task<OrphansResponse> GetOrphansAsync(OrphanParameters parameters)
        //{
            // string queryString = $"?pageSize={parameters.PageSize}&pageNumber={parameters.PageNumber}";
            // string url = $"{ httpService.BaseAddress }/{Controller}{queryString} ";
            //
            // var request = new HttpRequestMessage(HttpMethod.Get, url);
            //
            // // TODO Add JWT token to header
            // // request.Headers 
            //
            // var response = await httpClient.SendAsync(request);
            // try
            // {
            //     response.EnsureSuccessStatusCode();
            // }
            // catch (HttpRequestException ex)
            // {
            //     // TODO log exception
            // }
            //
            // IEnumerable<string> xPagination;
            // response.Headers.TryGetValues("X-Pagination", out xPagination);
            //
            // ResponseMetaData metaData = null;
            // if (xPagination != null)
            // {
            //     string xPaginationData = xPagination.FirstOrDefault();
            //     metaData = JsonSerializer.Deserialize<ResponseMetaData>(xPaginationData,
            //         new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            // }
            //
            // var content = await response.Content.ReadAsStringAsync();
            // var orphans = JsonSerializer.Deserialize<List<Orphan>>(content,
            //     new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            //
            // return new OrphansResponse {Orphans = orphans, MetaData = metaData};

        //    return null;
        //}

        public async Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await httpService.Get<OrphanDetailsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }

        public async Task<GuardianModel> GetOrphanGuardianAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/getOrphanGuardian/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<GuardianModel>(url);
            if (!response.Success)
            {
                // TODO throws 404 exception in browser
                //throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<SponsorModel>> GetOrphanSponsorsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/getOrphanSponsors/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<SponsorModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<PictureModel>> GetOrphanPicturesAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/orphanPictures/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<PictureModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<List<PDFModel>> GetOrphanPDFsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/orphanPDFs/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<PDFModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddOrphanAsync(OrphanCreationModel newOrphan)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}";
            var response = await httpService.Post(url, newOrphan);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateOrphanAsync(int orphanId, OrphanEditModel orphanEdit)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/{orphanId}";
            var response = await httpService.Put(url, orphanEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task PatchOrphanAsync(int orphanId, string propertyName, string newValue = null)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/{orphanId}";

            /*    JSON body example for patch request         
             [
                {
                    "value": "Smith",
                    "path": "/lastName",
                    "op": "replace"
                }
             ]
             */

            string json = "";
            if (newValue != null)
            {
                json = $"[{{\"value\": \"{newValue}\", \"path\": \"/{propertyName}\", \"op\": \"replace\"}}]";
            }
            else
            {
                json = $"[{{\"value\": {null}, \"path\": \"/{propertyName}\", \"op\": \"replace\"}}]";
            }
            
            var response = await httpService.Patch(url, json);
            
            if (!response.Success)
            {
                // TODO throws 404 exception in browser
               // throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteOrphanAsync(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{Controller}/{orphanId}";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        //public Task<OrphansResponse> GetOrphansAsync(OrphanParameters parameters)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<OrphanDetailsModel> IOrphanRepository.GetOrphanDetailsAsync(int orphanId)
        //{
        //    throw new NotImplementedException();
        //}

        //
        // TODO
        // Update UpdateDb entity
        //
    }
}