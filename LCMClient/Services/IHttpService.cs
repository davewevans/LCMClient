using LCMClient.Helpers;
using System.Threading.Tasks;

namespace LCMClient.Services
{
    public interface IHttpService
    {
        string BaseUrl { get; }
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T data);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T data);
        Task<HttpResponseWrapper<object>> Patch(string url, string data);
        Task<HttpResponseWrapper<object>> Delete(string url);
    }
}
