using LCMClient.Features.Guardians.Models;
using LCMClient.Features.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository.Contracts
{
    public interface IGuardianRepository
    {
        Task<List<GuardianModel>> GetGuardiansAsync();

        Task<GuardianDetailsModel> GetGuardianAsync(int guradianId);

        Task<List<OrphanModel>> GetGuardianOrphansAsync(int guardianId);

        Task AddGuardianAsync(GuardianCreationModel newGuardian);

        Task UpdateGuardianAsync(int guardianId, GuardianEditModel guardian);

        Task DeleteGuardianAsync(int guardianId);
    }
}
