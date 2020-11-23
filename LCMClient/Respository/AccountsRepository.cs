using LCMClient.Auth;
using LCMClient.DTOs;
using LCMClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Respository
{
    public class AccountsRepository : IAccountsRepository
    {
        private readonly IHttpService httpService;
        private readonly string controller = "accounts";
        private readonly string url = "";

        public AccountsRepository(IHttpService httpService)
        {
            this.httpService = httpService;
            this.url = $"{ httpService.BaseUrl }{ controller }";
        }

        public async Task<RegisterResponseWrapper> Register(UserCreation userInfo)
        {
            var httpResponse = await httpService.Post<UserCreation, UserToken>($"{url}/create", userInfo);

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

        public async Task<LoginResponseWrapper> Login(UserInfo userInfo)
        {
            var httpResponse = await httpService.Post<UserInfo, UserToken>($"{url}/login", userInfo);

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

        public async Task<bool> ResetPassword(string userId, PasswordResetDTO resetPassword)
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
