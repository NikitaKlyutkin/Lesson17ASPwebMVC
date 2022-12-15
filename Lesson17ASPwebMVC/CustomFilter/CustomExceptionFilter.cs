using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using ExceptionContext = Microsoft.AspNetCore.Mvc.Filters.ExceptionContext;

namespace Lesson17ASPwebMVC.CustomFilter
{
    public class CustomExceptionFilter : Attribute, IAsyncExceptionFilter
    {
	    public async Task OnExceptionAsync(ExceptionContext filterContext)
	    {
			var exc = filterContext.Exception;
			if (exc is ArgumentOutOfRangeException)
			{
				//filterContext.Result = new BadRequestObjectResult("Error");
				filterContext.Result = new RedirectToRouteResult(
					new RouteValueDictionary(
						new
						{
							Controller = "Product",
							action = "CustomError"
						}));

				filterContext.ExceptionHandled = true;
				
			}
		}
    }
}
