﻿using LCMClient.Auth;

namespace LCMClient.Helpers
{
    public class RegisterResponseWrapper
    {
        public UserToken Token { get; set; }

        public bool IsSuccessful { get; set; }

        public string ResponseMessage { get; set; }
    }
}
