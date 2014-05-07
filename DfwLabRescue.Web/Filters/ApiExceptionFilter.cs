using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace DfwLabRescue.Web.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        private static Logger Logger = LogManager.GetLogger("Api Exception Filter");
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            Logger.ErrorException("Api Exception Occurred", actionExecutedContext.Exception.GetBaseException());
            base.OnException(actionExecutedContext);
        }
    }
}