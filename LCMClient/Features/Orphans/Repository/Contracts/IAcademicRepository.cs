using LCMClient.Features.Orphans.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository.Contracts
{
    public interface IAcademicRepository
    {
        Task<List<AcademicModel>> GetOrphanAcademics(int orphanId);

        Task AddAcademicAsync(AcademicCreationModel newAcademic);

        Task UpdateAcademicAsync(int academicId, AcademicEditModel academicEdit);

        Task DeleteAcademicAsync(int academicId);
    }
}
