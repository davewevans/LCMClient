using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task AddNarrationAsync(NarrationCreationModel newNarration)
        {
            string url = $"{ httpService.BaseUrl }/{ Controller }";
            var response = await httpService.Post(url, newNarration);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateNarrationAsync(int narrationId, NarrationEditModel narrationEdit)
        {
            string url = $"{ httpService.BaseUrl }/{ Controller }/{ narrationId }";
            var response = await httpService.Put(url, narrationEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteNarrationAsync(int narrationId)
        {
            string url = $"{ httpService.BaseUrl }/{ Controller }/{ narrationId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<NarrationModel>> GetOrphanNarrations(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }/{ Controller }/{ "orphan" }/{ orphanId }";
            var response = await httpService.Get<List<NarrationModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<NarrationModel>> GetGuardianNarrations(int guradianId)
        {
            string url = $"{ httpService.BaseUrl }/{ Controller }/{ "guardian" }/{ guradianId }";
            var response = await httpService.Get<List<NarrationModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}