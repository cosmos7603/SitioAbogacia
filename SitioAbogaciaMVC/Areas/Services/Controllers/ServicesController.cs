using System.Web.Mvc;
using SitioAbogaciaMVC.Areas.Home.Models;
using SitioAbogaciaMVC.Code.MVC;

namespace SitioAbogaciaMVC.Areas.Services.Controllers
{

	[ViewsPath("~/Areas/Home/Views")]
	public class ServicesController : Controller
	{
		// GET: home
		public ActionResult Services()
		{
			var model = new ContactModel();
			return View(model);
		}

	


	}
}
