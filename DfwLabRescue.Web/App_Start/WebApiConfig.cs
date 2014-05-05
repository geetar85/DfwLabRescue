using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace DfwLabRescue.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var trace = config.EnableSystemDiagnosticsTracing();
            //trace.IsVerbose = true;
            //trace.MinimumLevel = System.Web.Http.Tracing.TraceLevel.Debug;
            // Web API routes
            config.MapHttpAttributeRoutes();

        }
    }
}
