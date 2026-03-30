using System.Net;
using System.Text.Json;
using Serilog;

namespace Reesp_Api_Crud.Middleware
{
    public class GlobException
    {
        private readonly RequestDelegate _next;

        public GlobException(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                Log.Error(ex,"Exception Occure"); // for serilog
                await HandleException(context, ex);
            }
        }   
        
        private Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonSerializer.Serialize(new
            {
                StatusCode = context.Response.StatusCode,
                Message = ex.Message
            });

            return context.Response.WriteAsync(result);
        }
    }
}
