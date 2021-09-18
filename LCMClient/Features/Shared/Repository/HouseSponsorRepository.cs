using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Services;
using System;
using System.Threading.Tasks;

namespace LCMClient.Repository
{
    public class OrphanSponsorRepository : IOrphanSponsorRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "orphanssponsors";
        private readonly string url = "";

        public OrphanSponsorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }
        
        public async Task AddAssignment(OrphanSponsorModel orphanSponsor)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/assignSponsor";
            var response = await httpService.Post(url, orphanSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task RemoveAssignment(OrphanSponsorModel orphanSponsor)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/removeSponsor";
            var response = await httpService.Post(url, orphanSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}