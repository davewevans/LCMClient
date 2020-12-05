using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
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
            var response = await httpService.Get<List<OrphanModel>>($"{ url }/allOrphans");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId)
        {
            var response = await httpService.Get<OrphanDetailsModel>($"{ url }/orphanDetails/{ orphanId }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }

        public async Task<GuardianModel> GetOrphanGuardianAsync(int orphanId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{ url }/orphanGuardian/{ orphanId }");
            
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
            // var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<SponsorModel>>($"{ url }/orphanSponsors/{ orphanId }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<PictureModel>> GetOrphanPicturesAsync(int orphanId)
        {            
            var response = await httpService.Get<List<PictureModel>>($"{ url }/orphanPictures/{ orphanId }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }  

        public async Task AddOrphanAsync(OrphanCreationModel newOrphan)
        {
            var response = await httpService.Post(url, newOrphan);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateOrphanAsync(int orphanId, OrphanEditModel orphanEdit)
        {
            var response = await httpService.Put($"{ url }/{ orphanId }", orphanEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task PatchOrphanAsync(int orphanId, string propertyName, string newValue = null)
        {
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
            
            var response = await httpService.Patch($"{ url }/{ orphanId }", json);
            
            if (!response.Success)
            {
                // TODO throws 404 exception in browser
               // throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteOrphanAsync(int orphanId)
        {
            var response = await httpService.Delete($"{ url }/{ orphanId }");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}