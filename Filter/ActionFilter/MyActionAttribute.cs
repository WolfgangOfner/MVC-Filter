using System.Web.Mvc;

namespace Filter.ActionFilter
{
    public class MyActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Browser.Browser == "Chrome")
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
        }
    }
}