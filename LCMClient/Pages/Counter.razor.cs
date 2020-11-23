using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Pages
{
    public partial class Counter
    {
        [CascadingParameter]
        private Task<AuthenticationState> authenticationState { get; set; }

        private int currentCount = 0;

        private async Task IncrementCount()
        {
            var authState = await authenticationState;
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                currentCount++;
            }
            else
            {
                currentCount--;
            }
            
        }
    }
}
