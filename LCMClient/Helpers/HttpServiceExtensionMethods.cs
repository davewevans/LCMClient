using LCMClient.Features.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMClient.Helpers
{
    public static class HttpServiceExtensionMethods
    {
        public static async Task<T> GetHelper<T>(this IHttpService httpService, string url)
        {
            var response = await httpService.Get<T>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public static async Task<PaginatedResponse<T>> GetHelper<T>(this IHttpService httpService, string url,
            PaginationDTO paginationDTO)
        {
            string newURL = "";
            if (url.Contains("?"))
            {
                newURL = $"{url}&page={paginationDTO.Page}&recordsPerPage={paginationDTO.RecordsPerPage}";
            }
            else
            {
                newURL = $"{url}?page={paginationDTO.Page}&recordsPerPage={paginationDTO.RecordsPerPage}";
            }

            var httpResponse = await httpService.Get<T>(newURL);
            int totalAmountPages = 1;       

            try
            {             
                totalAmountPages = int.Parse(httpResponse.HttpResponseMessage.Headers.GetValues("totalAmountPages")?.FirstOrDefault());
            }
            catch (Exception ex)
            {
                // TODO log exception
                Console.WriteLine($"HttpServiceExtensionMethods.GetHelper: { ex.Message }");
            }
                
            var paginatedResponse = new PaginatedResponse<T>
            {
                Response = httpResponse.Response,
                TotalAmountPages = totalAmountPages
            };
            return paginatedResponse;
        }
    }
}
