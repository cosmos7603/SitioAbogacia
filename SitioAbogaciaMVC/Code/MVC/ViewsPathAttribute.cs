using System;

namespace SitioAbogaciaMVC.Code.MVC
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class ViewsPath : Attribute
	{
		public string BasePath { get; set; }

		public ViewsPath(string basePath)
		{
			BasePath = basePath;
		}
	}
}