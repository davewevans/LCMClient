using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LCMClient.Features.Auth
{
    public class DummyAuthenticationStateProvider : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            await Task.Delay(3000);
            var anonymous = new ClaimsIdentity(new List<Claim>() {
                new Claim(ClaimTypes.Name, "Dave"),
                new Claim(ClaimTypes.Email, "dave@gmail.com"),
                new Claim(ClaimTypes.Role, "Admin"),
                new Claim(ClaimTypes.Role, "User"),
            }, "foo"); ;
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));
        }
    }
}
