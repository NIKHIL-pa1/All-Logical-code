using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
    public class CustomExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine(">>> Exception Filter Executed");

            var response = new
            {
                Status = "Error",
                Message = context.Exception.Message,
                Detail = "Something went wrong. Please contact support."
            };

            context.Result = new ObjectResult(response)
            {
                StatusCode = 500
            };
            context.ExceptionHandled = true;
        }
    }
}
