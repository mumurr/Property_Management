using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Property_Management
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Web API 配置和服务
            /*  config.EnableCors(new EnableCorsAttribute("*", "*", "*"));*/
            //跨域配置
            config.EnableCors(new System.Web.Http.Cors.EnableCorsAttribute("*", "*", "*"));
        }
    }
}
