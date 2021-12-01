using Examination.API.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace Examination.API.Extension
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorWrapping(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorWrappingMiddleware>();
        }
    }
}
