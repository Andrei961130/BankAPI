
using Core.DTOs;
using Microsoft.AspNetCore.Http;

namespace Core.ExtensionMethods
{
    public static class HttpContextExtensions
    {
        public static void AddPaginationHeaders(this HttpContext context, PaginationRequest pagination, int total)
        {
            context.Response.Headers.Add("X-Page-Number", Convert.ToString(pagination.PageNumber));
            context.Response.Headers.Add("X-Page-Size", Convert.ToString(pagination.PageSize));
            context.Response.Headers.Add("X-Page-Total", Convert.ToString(total));
        }
    }
}
