using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMClient.Repository.Contracts
{
    public interface IAcademicRepository
    {
        Task<List<Academic>> GetOrphanAcademics(int orphanId);
        
        Task AddAcademicAsync(AcademicCreation newAcademic);

        Task UpdateAcademicAsync(int academicId, AcademicEdit academicEdit);

        Task DeleteAcademicAsync(int academicId);
    }
}