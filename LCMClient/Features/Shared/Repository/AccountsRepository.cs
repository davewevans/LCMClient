using LCMClient.Features.Admin.Models;
using LCMClient.Features.Auth.Models;
using LCMClient.Features.Shared.Repository.Contracts;
using LCMClient.Services;
using System;
using System.Threading.Tasks;

namespace LCMClient.Features.Shared.Repository
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "accounts";
        private readonly string url = "";

        public AccountsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ Controller }";
        }

        public async Task<RegisterResponseWrapper> Register(UserCreationModel userInfo)
        {
            var httpResponse = await httpService.Post<UserCreationModel, UserToken>($"{url}/create", userInfo);

            if (!httpResponse.Success)
            {
                return new RegisterResponseWrapper
                {
                    Token = null,
                    IsSuccessful = false,
                    ResponseMessage = await httpResponse.GetBody()
                };
                // throw new ApplicationException(await httpResponse.GetBody());
            }

            return new RegisterResponseWrapper
            {
                Token = httpResponse.Response,
                IsSuccessful = true,
                ResponseMessage = ""
            };
        }     

        public async Task<LoginResponseWrapper> Login(UserInfoModel userInfo)
        {
            var httpResponse = await httpService.Post<UserInfoModel, UserToken>($"{url}/login", userInfo);

            if (!httpResponse.Success)
            {
                return new LoginResponseWrapper
                {
                    Token = null,
                    IsSuccessful = false,
                    ResponseMessage =await httpResponse.GetBody()
                };
                // throw new ApplicationException(await httpResponse.GetBody());
            }

            return new LoginResponseWrapper
            {
                Token = httpResponse.Response,
                IsSuccessful = true,
                ResponseMessage = ""
            };
        }

        public async Task<UserToken> RenewToken()
        {
            var response = await httpService.Get<UserToken>($"{url}/RenewToken");

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task<bool> ResetPassword(string userId, PasswordResetModel resetPassword)
        {
            var response = await httpService.Put($"{url}/resetPassword/{userId}", resetPassword);

            if (!response.Success)
            {
                return false;
            }
            return true;
        }
    }
}
