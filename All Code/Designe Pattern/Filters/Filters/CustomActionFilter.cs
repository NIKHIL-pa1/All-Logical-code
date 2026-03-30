using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.Numerics;

namespace Filters.Filters
{
    public class CustomActionFilter : ActionFilterAttribute
    {
        private Stopwatch stopwatch;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Action filter Starting...");
            addition();
        }

        public void addition()
        {
            int c = 10+20;
            Console.WriteLine(c);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            stopwatch.Stop();
            Console.WriteLine($"Action filter Finished in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
