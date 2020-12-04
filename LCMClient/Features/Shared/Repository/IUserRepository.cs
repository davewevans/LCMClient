using LCMClient.Features.Admin.Models;
using LCMClient.Features.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository
{
    public interface IUserRepository
    {
        Task AssignRole(EditRoleModel editRole);
        Task<List<RoleModel>> GetRoles();
        Task<PaginatedResponse<List<UserModel>>> GetUsers(PaginationModel paginationDTO);
        Task RemoveRole(EditRoleModel editRole);
        Task EditUser(string id, UserEditModel userEdit);
        Task<UserModel> GetUserById(string id);
        Task DeleteUser(string id);
    }
}
