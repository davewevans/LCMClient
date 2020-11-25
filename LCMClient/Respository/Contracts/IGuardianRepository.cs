using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMClient.Repository.Contracts
{
    public interface IGuardianRepository
    {
        Task<List<Guardian>> GetGuardiansAsync();

        Task<Guardian> GetGuardianAsync(int guradianId);

        Task AddGuardianAsync(GuardianCreation newGuardian);

        Task UpdateGuardianAsync(int guardianId, GuardianEdit guardian);

        Task DeleteGuardianAsync(int guardianId);
    }
}