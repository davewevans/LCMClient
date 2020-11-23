using LCMClient.Auth;
using LCMClient.DTOs;
using LCMClient.Helpers;
using System.Threading.Tasks;

namespace LCMClient.Respository
{
    public interface IAccountsRepository
    {
        Task<LoginResponseWrapper> Login(UserInfo userInfo);
        Task<RegisterResponseWrapper> Register(UserCreation userInfo);
        Task<bool> ResetPassword(string userId, PasswordResetDTO resetPassword);
        Task<UserToken> RenewToken();
    }
}
