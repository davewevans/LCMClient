using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository.Contracts
{
    public interface IOrphanRepository
    {
        Task<List<OrphanModel>> GetAllOrphansAsync();

        // Task<OrphansResponse> GetOrphansAsync(OrphanParameters parameters);

        Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId);
        
        Task<GuardianModel> GetOrphanGuardianAsync(int orphanId);

        Task<List<SponsorModel>> GetOrphanSponsorsAsync(int orphanId);

        Task<List<PictureModel>> GetOrphanPicturesAsync(int orphanId);        
        
        Task AddOrphanAsync(OrphanCreationModel newOrphan);

        Task UpdateOrphanAsync(int orphanId, OrphanEditModel orphanEdit);

        Task PatchOrphanAsync(int orphanId, string propertyName, string newValue=null);

        Task DeleteOrphanAsync(int orphanId);
    }
}
