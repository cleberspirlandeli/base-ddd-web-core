using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
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
            // Inserir erro no banco
            
            httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var message = "Ops, ocorreu um erro inesperado. Tente novamente mais tarde! Erro ${Erro.Id} - " + ex.Message;

            var result = JsonConvert.SerializeObject(new { success = false, errors = message });
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync(result);

        }
    }
}
