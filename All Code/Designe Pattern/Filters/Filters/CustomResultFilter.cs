using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Filters.Filters
{
    public class CustomResultFilter : ResultFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine(">>> Result Filter: Before Result Execution");
            if (context.Result is ObjectResult objectResult)
            {
                objectResult.Value = new
                {
                    Status = "Success",
                    Data = objectResult.Value,
                    Message = "Response modified by Result Filter"
                };
            }
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine(">>> Result Filter: After Result Execution");
        }


    }
}
