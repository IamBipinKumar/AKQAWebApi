/// <summary>
/// AKQA Web API namespace
/// </summary>
namespace AKQAWebAPI
{
    using System.Web.Mvc;

    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}