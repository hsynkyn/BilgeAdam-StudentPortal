using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WEB.ActionFilters
{
    public class ValidateModelWithTempDataAttribute : ActionFilterAttribute, IAsyncActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var httpMethod = 
                context.HttpContext.Request.Method;
            var controller = context.Controller as Controller;

            if (httpMethod != "POST") return;

            if(!context.ModelState.IsValid && controller != null)
            {
                controller.TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!!";

                var actionName = context.ActionDescriptor.RouteValues["action"];
                var model = context.ActionArguments.Values.FirstOrDefault();

                context.Result = controller.View(actionName, model);
            }
        }
    }
}
