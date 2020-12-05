using LCMClient.Features.Admin.Models;
using LCMClient.Features.Shared.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Helpers;
using LCMClient.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "users";
        private readonly string url = "";

        public UserRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }

        public async Task<PaginatedResponse<List<UserModel>>> GetUsers(PaginationModel pagination)
        {
            return await httpService.GetHelper<List<UserModel>>(url, pagination);
        }


        public async Task<UserModel> GetUserById(string id)
        {
            var response = await httpService.Get<UserModel>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task EditUser(string id, UserEditModel userEdit)
        {
            var response = await httpService.Put($"{url}/{id}", userEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteUser(string id)
        {
            var response = await httpService.Delete($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<RoleModel>> GetRoles()
        {
            return await httpService.GetHelper<List<RoleModel>>($"{url}/roles");
        }

        public async Task AssignRole(EditRoleModel editRole)
        {
            var response = await httpService.Post($"{url}/assignRole", editRole);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task RemoveRole(EditRoleModel editRole)
        {
            var response = await httpService.Post($"{url}/removeRole", editRole);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
