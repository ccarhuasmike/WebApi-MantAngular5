using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApoMant.Utils;

namespace WebApoMant
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            EnableCorsAttribute defaultPolicyProvider = new EnableCorsAttribute(ConfigurationManager.AppSettings["host"], "*", "GET,POST");
            config.EnableCors(defaultPolicyProvider);
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });

        }
    }
}
