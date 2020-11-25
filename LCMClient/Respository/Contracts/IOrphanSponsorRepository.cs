using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMClient.Repository.Contracts
{
    public interface IOrphanSponsorRepository
    {
        Task AddAssignment(OrphanSponsor orphanSponsor);

        Task RemoveAssignment(OrphanSponsor orphanSponsor);
    }
}