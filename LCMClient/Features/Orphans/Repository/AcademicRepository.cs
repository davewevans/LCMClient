using LCMClient.Features.Orphans.Models;
using LCMClient.Features.Orphans.Repository.Contracts;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Orphans.Repository
{
    public class AcademicRepository : IAcademicRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "academics";
        private readonly string url = "";

        public AcademicRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }

        public async Task<List<AcademicModel>> GetOrphanAcademics(int orphanId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/orphan/{ orphanId }";
            var response = await httpService.Get<List<AcademicModel>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddAcademicAsync(AcademicCreationModel newAcademic)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }";
            var response = await httpService.Post(url, newAcademic);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateAcademicAsync(int academicId, AcademicEditModel academicEdit)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{academicId}";
            var response = await httpService.Put(url, academicEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteAcademicAsync(int academicId)
        {
            string url = $"{ httpService.BaseUrl }{ Controller }/{ academicId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}