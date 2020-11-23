using LCMClient.Features.Admin.DTOs;
using LCMClient.Features.Admin.Models;
using LCMClient.Features.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LCMClient.Respository
{
    public interface IUserRepository
    {
        Task AssignRole(EditRoleDTO editRole);
        Task<List<RoleDTO>> GetRoles();
        Task<PaginatedResponse<List<UserDTO>>> GetUsers(PaginationDTO paginationDTO);
        Task RemoveRole(EditRoleDTO editRole);
        Task EditUser(string id, UserEdit userEdit);
        Task<UserDTO> GetUserById(string id);

        Task DeleteUser(string id);
    }
}
