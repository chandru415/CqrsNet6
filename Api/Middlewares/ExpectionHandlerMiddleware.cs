using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Api.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExpectionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExpectionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExpectionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseExpectionHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExpectionHandlerMiddleware>();
        }
    }
}
