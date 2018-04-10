using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Amazon.XRay.Recorder.Handlers.AspNet;

namespace XRayTest
{
    public class Global : HttpApplication
    {
        public override void Init()
        {
            base.Init();

            AWSXRayASPNET.RegisterXRay(this, "ASPNETTest"); // default name of the web app
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }
    }
}