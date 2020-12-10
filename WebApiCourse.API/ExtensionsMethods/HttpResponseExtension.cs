using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WebApiCourse.API.Helpers;

namespace WebApiCourse.API.ExtensionsMethods
{
    public static class HttpResponseExtension
    {
        public static void AddPagination(this HttpResponse response, 
            int currentPage, int pageSize, int totalPages, int totalCount)
        {
            var paginationHearder = new PaginationHeader(currentPage, pageSize, totalPages, totalCount);

            var camelCaseFormatter = new JsonSerializerSettings();
            camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();

            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHearder, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Header", "Pagination");
        }
    }
}