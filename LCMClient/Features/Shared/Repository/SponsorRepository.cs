using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Features.Sponsors.Models;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Repository
{
    public class SponsorRepository : ISponsorRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "sponsors";
        private readonly string url = "";

        public SponsorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }
        
        public async Task<List<SponsorModel>> GetSponsorsAsync()
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Get<List<SponsorModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<SponsorDetailsModel> GetSponsorDetailsAsync(int sponsorId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/sponsorDetails/{ sponsorId }";
            var response = await httpService.Get<SponsorDetailsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;;
        }

        public async Task<List<OrphanModel>> GetSponsorOrphansAsync(int sponsorId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/sponsorOrphans/{ sponsorId }";
            var response = await httpService.Get<List<OrphanModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddSponsorAsync(SponsorCreationModel newSponsor)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Post(url, newSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateSponsorAsync(int sponsorId, SponsorEditModel sponsorEdit)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{sponsorId}";
            var response = await httpService.Put(url, sponsorEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSponsorAsync(int sponsorId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ sponsorId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}