﻿using DfwLabRescue.Web.Filters;
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
            config.Filters.Add(new ApiExceptionFilter());
            // Web API routes
            config.MapHttpAttributeRoutes();

        }
    }
}
