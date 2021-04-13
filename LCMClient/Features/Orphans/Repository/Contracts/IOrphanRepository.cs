﻿using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository.Contracts
{
    public interface IOrphanRepository
    {
        Task<List<Models.OrphanModel>> GetAllOrphansAsync();

        // Task<OrphansResponse> GetOrphansAsync(OrphanParameters parameters);

        Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId);
        
        Task<GuardianModel> GetOrphanGuardianAsync(int orphanId);

        Task<List<SponsorModel>> GetOrphanSponsorsAsync(int orphanId);

        Task<List<PictureModel>> GetOrphanPicturesAsync(int orphanId);

        Task<List<OrphanHistoryDTO>> GetOrphanHistoryAsync(int orphanId);

        Task AddOrphanHistoryAsync(OrphanHistoryDTO history);
        
        Task AddOrphanAsync(OrphanCreationModel newOrphan);

        Task UpdateOrphanAsync(int orphanId, OrphanEditModel orphanEdit);

        Task PatchOrphanAsync(int orphanId, string propertyName, string newValue=null);

        Task DeleteOrphanAsync(int orphanId);
    }
}
