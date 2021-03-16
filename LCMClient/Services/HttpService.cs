using LCMClient.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LCMClient.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient httpClient; 
                 
                 private JsonSerializerOptions defaultJsonSerializerOptions =>
                     new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
         
                 public HttpService(HttpClient httpClient)
                 {
                     this.httpClient = httpClient;
                 }
         
                 public string BaseUrl => httpClient?.BaseAddress?.AbsoluteUri;
         
                 public async Task<HttpResponseWrapper<T>> Get<T>(string url)
                 {
                     var responseHTTP = await httpClient.GetAsync(url);
         
                     if (responseHTTP.IsSuccessStatusCode)
                     {
                         var response = await Deserialize<T>(responseHTTP, defaultJsonSerializerOptions);
                         return new HttpResponseWrapper<T>(response, true, responseHTTP);
                     }
                     else
                     {
                         return new HttpResponseWrapper<T>(default, false, responseHTTP);
                     }
                 }
         
                 public async Task<HttpResponseWrapper<object>> Post<T>(string url, T data)
                 {
                     var dataJson = JsonSerializer.Serialize(data);
                     var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
                     var response = await httpClient.PostAsync(url, stringContent);
                     return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
                 }
                 
                 public async Task<HttpResponseWrapper<object>> PostForm(string url, MultipartFormDataContent content)
                 {
                     var response = await httpClient.PostAsync(url, content);
                     return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
                 }
         
                 public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T data)
                 {
                     var dataJson = JsonSerializer.Serialize(data);
                     var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
                     var response = await httpClient.PostAsync(url, stringContent);
                     if (response.IsSuccessStatusCode)
                     {
                         var responseDeserialized = await Deserialize<TResponse>(response, defaultJsonSerializerOptions);
                         return new HttpResponseWrapper<TResponse>(responseDeserialized, true, response);
                     }
                     else
                     {
                         return new HttpResponseWrapper<TResponse>(default, false, response);
                     }
                 }
                 
                 public async Task<HttpResponseWrapper<object>> Put<T>(string url, T data)
                 {
                     var dataJson = JsonSerializer.Serialize(data);
                     var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
                     var response = await httpClient.PutAsync(url, stringContent);
                     return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
                 }
                 
                 public async Task<HttpResponseWrapper<object>> Patch(string url, string data)
                 {
                     var stringContent = new StringContent(data, Encoding.UTF8, "application/json");
                     var response = await httpClient.PatchAsync(url, stringContent);
                     return new HttpResponseWrapper<object>(null, response.IsSuccessStatusCode, response);
                 }
         
                 public async Task<HttpResponseWrapper<object>> Delete(string url)
                 {
                     var responseHTTP = await httpClient.DeleteAsync(url);
                     return new HttpResponseWrapper<object>(null, responseHTTP.IsSuccessStatusCode, responseHTTP);
                 }        
                 
                 private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
                 {
                     var responseString = await httpResponse.Content.ReadAsStringAsync();
                     return JsonSerializer.Deserialize<T>(responseString, options);
                 }
                 
                 public async Task<bool> HasInternetConnection()
                 {
                     // A somewhat naive check for intentet connection but should serve the purpose.
                     // Tries to hit an API endpoint, if it returns a 200 success status code 
                     // then all is good. If not, the client could switch to offline mode. 
         
                     string apiUrl = $"{ httpClient?.BaseAddress?.AbsoluteUri }connectioncheck";
         
                     try
                     {
                         var responseHTTP = await httpClient.GetAsync(apiUrl);
                         return responseHTTP.IsSuccessStatusCode ? true : false;               
                     }
                     catch (Exception)
                     {
                         return false;
                     }
                 }
    }
}