using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitio.Models;

namespace Sitio.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
		public ActionResult Index()
		{
			var model = new ContactModel();
			return View(model);
		}
	}
}