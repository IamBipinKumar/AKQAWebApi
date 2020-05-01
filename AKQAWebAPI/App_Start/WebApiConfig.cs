/// <summary>
/// AKQA Web API namespace
/// </summary>
namespace AKQAWebAPI
{
    using System.Web.Http;
    using WebApiContrib.Formatting.Jsonp;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { controller = "Home", id = RouteParameter.Optional }
            );

            var jsonpFormatter = new JsonpMediaTypeFormatter(config.Formatters.JsonFormatter);
            config.Formatters.Insert(0, jsonpFormatter);
        }
    }
}
