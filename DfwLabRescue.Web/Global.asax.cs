using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using DfwLabRescue.Web.App_Start;
using NLog;

namespace DfwLabRescue.Web
{
    public class Global : HttpApplication
    {
        private static Logger Logger = LogManager.GetLogger("Global Logger");
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DbConfig.LoadDb();
        }

        void Application_Error(object sender, EventArgs e)
        {
            var error = Server.GetLastError().GetBaseException();

            Logger.ErrorException("Unhandled Error Occurred", error);
        }

    }
}