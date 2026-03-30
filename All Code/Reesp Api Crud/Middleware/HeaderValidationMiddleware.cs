namespace Reesp_Api_Crud.Middleware
{
    //public class HeaderValidationMiddleware
    //{
    //    private readonly RequestDelegate _next;

    //    public HeaderValidationMiddleware(RequestDelegate next)
    //    {
    //        _next = next;
    //    }

    //    public async Task InvokeAsync(HttpContext context)
    //    {
    //        if (!context.Request.Headers.TryGetValue("X-API-KEY", out var apiKey))
    //        {
    //            context.Response.StatusCode = StatusCodes.Status400BadRequest;
    //            await context.Response.WriteAsync("Missing API Key");
    //            return;
    //        }

    //        if (apiKey != "my-secret-key")
    //        {
    //            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
    //            await context.Response.WriteAsync("Invalid API Key");
    //            return;
    //        }

    //        await _next(context);
    //    }
    //}
}
