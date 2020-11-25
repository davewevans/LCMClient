using System.Threading.Tasks;
using LCMClient.Features.Dashboard.Models;

namespace LCMClient.Features.Dashboard
{
    public interface IDashboardRepository
    {
        Task<TotalCountsModel> GetTotalCounts();
        
        Task<OrphanStatisticsModel> GetOrphanStatistics();

        Task<NarrationStatisticsModel> GetNarrationStatistics();
    }
}