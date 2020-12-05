using LCMClient.Features.Admin.Models;
using LCMClient.Features.Auth.Models;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository.Contracts
{
    public interface IAccountsRepository
    {
        Task<LoginResponseWrapper> Login(UserInfoModel userInfo);
        Task<RegisterResponseWrapper> Register(UserCreationModel userInfo);
        Task<bool> ResetPassword(string userId, PasswordResetModel resetPassword);
        Task<UserToken> RenewToken();
    }
}
