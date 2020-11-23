using LCMClient.Features.Auth.Models;
using System.Threading.Tasks;

namespace LCMClient.Features.Auth
{
    public interface ILoginService
    {      
        Task Login(UserToken userToken);
        Task Logout();
        Task TryRenewToken();
    }
}
