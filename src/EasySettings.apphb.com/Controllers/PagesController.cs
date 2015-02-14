namespace EasySettings.apphb.com.Controllers
{
	using System.Web.Mvc;

	/// <summary>
	/// Pages controller.
	/// </summary>
    public class PagesController : Controller
    {

        /// <summary>
        /// Homepage
        /// </summary>
        public ActionResult Overview()
        {
            return View();
        }

		public void GetAppSettings()
		{
			
		}
    }
}