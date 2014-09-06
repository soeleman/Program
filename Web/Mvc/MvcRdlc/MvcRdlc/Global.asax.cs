﻿namespace MvcRdlc
{
    using System;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.Routing;
    
    public class Global 
        : HttpApplication
    {
        void Application_Start(
            Object sender, 
            EventArgs e)
        {
           AreaRegistration.RegisterAllAreas();
           RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}