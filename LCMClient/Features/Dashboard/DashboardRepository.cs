using System;
using System.Threading.Tasks;
using LCMClient.Features.Dashboard.Models;
using LCMClient.Services;

namespace LCMClient.Features.Dashboard
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly IHttpService httpService;
        private const string controller = "dashboard";
        private readonly string url = "";

        public DashboardRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ controller }";
        }
        
        public async Task<TotalCountsModel> GetTotalCounts()
        {
            string url = $"{ httpService.BaseUrl }{ controller }/totalCounts";
            var response = await httpService.Get<TotalCountsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<OrphanStatisticsModel> GetOrphanStatistics()
        {
            string url = $"{ httpService.BaseUrl }{ controller }/orphanStats";
            var response = await httpService.Get<OrphanStatisticsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<NarrationStatisticsModel> GetNarrationStatistics()
        {
            string url = $"{ httpService.BaseUrl }{ controller }/narrationStats";
            var response = await httpService.Get<NarrationStatisticsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}