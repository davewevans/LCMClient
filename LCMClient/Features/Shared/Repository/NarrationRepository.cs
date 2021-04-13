using LCMClient.Features.Shared.Narrations;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMClient.Features.Shared.Models;
using LCMClient.Helpers;

namespace LCMClient.Repository
{
    public class NarrationRepository : INarrationRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "narrations";
        private readonly string url = "";

        public NarrationRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }
        
        public async Task<NarrationModel> GetNarrationById(int id)
        {
            var response = await httpService.Get<NarrationModel>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<int> GetPendingNarrationsCount()
        {
            var response = await httpService.Get<int>($"{url}/pendingNarrationsCount");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task AddNarrationAsync(NarrationCreationModel newNarration)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Post(url, newNarration);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateNarrationAsync(int narrationId, NarrationEditModel narrationEdit)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ narrationId }";
            var response = await httpService.Put(url, narrationEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        
        public async Task<bool> ApproveNarrationAsync(int narrationId, NarrationModel narrationEdit)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/ApprovedNarration/{ narrationId }";
            var response = await httpService.Put(url, narrationEdit);
            return response.Success;
        }

        public async Task DeleteNarrationAsync(int narrationId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ narrationId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<NarrationModel>> GetOrphanNarrations(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ "orphanNarrations" }/{ orphanId }";
            var response = await httpService.Get<List<NarrationModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<NarrationModel>> GetGuardianNarrations(int guradianId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ "guardianNarrations" }/{ guradianId }";
            var response = await httpService.Get<List<NarrationModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<PaginatedResponse<List<NarrationModel>>> GetPendingApprovalNarrations(PaginationModel pagination)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ "pendingApprovalNarrations" }";
            return await httpService.GetHelper<List<NarrationModel>>(url, pagination);
            
            // var response = await httpService.Get<List<NarrationModel>>(url);
            // if (!response.Success)
            // {
            //     throw new ApplicationException(await response.GetBody());
            // }
            // return response.Response;
        }
    }
}