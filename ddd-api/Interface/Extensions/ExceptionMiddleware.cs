using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Interface.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
         
        private async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            // TODO - Add Elmah.oi
            //ex.Ship(httpContext);

            // Alguma outra regra de Negocio
            
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        }
    }
}
