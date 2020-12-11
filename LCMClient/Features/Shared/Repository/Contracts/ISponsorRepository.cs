using LCMClient.Features.Shared.Models;
using LCMClient.Features.Sponsors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository.Contracts
{
    public interface ISponsorRepository
    {
        Task<List<SponsorModel>> GetSponsorsAsync();

        Task<SponsorDetailsModel> GetSponsorDetailsAsync(int sponsorId);

        Task<List<OrphanModel>> GetSponsorOrphansAsync(int sponsorId);

        Task AddSponsorAsync(SponsorCreationModel newSponsor);

        Task UpdateSponsorAsync(int sponsorId, SponsorEditModel sponsor);

        Task DeleteSponsorAsync(int sponsorId);
    }
}
