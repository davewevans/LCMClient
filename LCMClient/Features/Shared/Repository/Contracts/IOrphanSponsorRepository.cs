using LCMClient.Features.Shared.Models;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository.Contracts
{
    public interface IOrphanSponsorRepository
    {
        Task AddAssignment(OrphanSponsorModel orphanSponsor);

        Task RemoveAssignment(OrphanSponsorModel orphanSponsor);
    }
}
