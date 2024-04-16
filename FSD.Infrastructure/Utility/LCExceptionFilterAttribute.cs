using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

namespace FSD.Infrastructure.Utility
{
    public class FSDExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly ILogger<FSDExceptionFilterAttribute> logger;

        public FSDExceptionFilterAttribute(ILogger<FSDExceptionFilterAttribute> logger)
        {
            this.logger = logger;
        }

        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);

            // Some logic to handle specific exceptions
            var errorMessage = context.Exception is ArgumentException
                ? "ArgumentException occurred"
                : "Some unknown error occurred";

            // Maybe, logging the exception
            logger.LogError(context.Exception, errorMessage);

            // Returning response
            context.Result = new BadRequestResult();
        }
    }
}
