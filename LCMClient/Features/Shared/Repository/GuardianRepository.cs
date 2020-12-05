using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMClient.Features.Guardians.Models;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Services;

namespace LCMClient.Repository
{
    public class GuardianRepository : IGuardianRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "guardians";
        private readonly string url = "";

        public GuardianRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }
        
        public async Task<List<GuardianModel>> GetGuardiansAsync()
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Get<List<GuardianModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<GuardianModel> GetGuardianAsync(int guardianId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ guardianId }";
            var response = await httpService.Get<GuardianModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddGuardianAsync(GuardianCreationModel newGuardian)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Post(url, newGuardian);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateGuardianAsync(int guardianId, GuardianEditModel guardianEdit)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{guardianId}";
            var response = await httpService.Put(url, guardianEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteGuardianAsync(int guardianId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ guardianId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}