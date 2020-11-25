using System.Net.Http;

namespace LCMClient.Helpers
{
    public class HttpClientWithoutToken
    {
        public HttpClient HttpClient { get; }

        public HttpClientWithoutToken(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}