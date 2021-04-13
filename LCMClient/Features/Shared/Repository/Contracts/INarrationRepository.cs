using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Narrations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository.Contracts
{
    public interface INarrationRepository
    {
        Task<NarrationModel> GetNarrationById(int id);
        
        Task AddNarrationAsync(NarrationCreationModel newNarration);

        Task UpdateNarrationAsync(int narrationId, NarrationEditModel narrationEdit);

        Task DeleteNarrationAsync(int narrationId);

        Task<List<NarrationModel>> GetOrphanNarrations(int orphanId);

        Task<List<NarrationModel>> GetGuardianNarrations(int guradianId);

        Task<PaginatedResponse<List<NarrationModel>>> GetPendingApprovalNarrations(PaginationModel pagination);

        Task<bool> ApproveNarrationAsync(int narrationId, NarrationModel narrationEdit);

        Task<int> GetPendingNarrationsCount();

    }
}



