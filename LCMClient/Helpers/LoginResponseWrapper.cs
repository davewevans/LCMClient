using LCMClient.Auth;

namespace LCMClient.Helpers
{
    public class LoginResponseWrapper
    {
        public UserToken Token { get; set; }

        public bool IsSuccessful { get; set; }

        public string ResponseMessage { get; set; }
    }
}
