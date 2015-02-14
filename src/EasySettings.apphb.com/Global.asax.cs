namespace EasySettings.apphb.com
{
	using System.Web.Mvc;
	using System.Web.Routing;

	/// <summary>
	/// Mvc application.
	/// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
