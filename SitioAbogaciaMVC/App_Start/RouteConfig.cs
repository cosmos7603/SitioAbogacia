﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SitioAbogaciaMVC
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			// Ignore axd resources
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// Attribute Routing
			routes.MapMvcAttributeRoutes();

			// Default routes
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
				namespaces: new[] { "SitioAbogaciaMVC.Controllers" }
			);
		}
	}
}
