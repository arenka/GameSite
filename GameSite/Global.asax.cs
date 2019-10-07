using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Autofac;
using GameSite.App_Start;
using GameSite.Data.Repositories;
using GameSite.Data.Repositories.Impl;
using GameSite.Service.Services;
using GameSite.Service.Services.Impl;

namespace GameSite
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            AutofacBootsrapper.Register();
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          

        }
    }
}