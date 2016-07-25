using System.Web.Http;

namespace TechTest01.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "",
                routeTemplate: "api/products",
                defaults: new { area="", controller= "Product" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { area = "", id = RouteParameter.Optional }
            );
        }
    }
}
