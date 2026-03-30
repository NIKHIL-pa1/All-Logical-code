using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Filters.Filters
{
    public class CustomResourceFilter 
    {
        private Stopwatch stopwatch;

        public override void OnResourceExecuting(ResourceExecutingContext context)
        {
            stopwatch = Stopwatch.StartNew();
            Console.WriteLine(">>> Resource Filter: Before Resource");

            // Example: Short-circuit condition
            var block = context.HttpContext.Request.Query["block"];

            if (block == "true")
            {
                context.Result = new ContentResult
                {
                    Content = "Request blocked by Resource Filter"
                };
            }
        }

        public override void OnResourceExecuted(ResourceExecutedContext context)
        {
            stopwatch.Stop();
            Console.WriteLine($">>> Resource Filter: After Resource ({stopwatch.ElapsedMilliseconds} ms)");
        }
    }
}
