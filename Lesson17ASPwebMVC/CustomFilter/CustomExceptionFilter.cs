using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson17ASPwebMVC.CustomFilter
{
    public class CustomExceptionFilter : ActionFilterAttribute,
        IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is NullReferenceException)
            {
                filterContext.Result = new RedirectResult("customErrorPage.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
