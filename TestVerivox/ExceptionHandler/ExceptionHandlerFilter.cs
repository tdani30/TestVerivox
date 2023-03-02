using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using TestVerivox.Model;

namespace TestVerivox.ExceptionHandler
{
    public class ExceptionHandlerFilter : IActionFilter
    {
        // The preceding filter specifies an Order of the maximum integer value minus 10.
        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is null)
                return;

            var response = FailureMessage(context.Exception.Message, context.HttpContext.Response.StatusCode); ;
            response.StatusCode = context.Exception switch
            {
                ExceptionDto exception => exception.StatusCode,
                ArgumentException => 422,
                _ => 500
            };
            context.Result = response;
            context.ExceptionHandled = true;

        }
        public static ObjectResult FailureMessage([ActionResultObjectValue] object data = default, [ActionResultStatusCode] int statusCode = 0)
        {
            return new(new ErrorResponse
            {
                Status = !(statusCode > 299),
                Message = data
            })
            {
                StatusCode = statusCode
            };
        }
    }

   
}
