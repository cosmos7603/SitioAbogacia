﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using System.Text;
using System.Web.Mvc;
using System.IO;

namespace AM.WebSite
{
	public class UrlGenerator
	{
		public Assembly ControllerAssembly { get; set; }
		public string BaseUrl { get; set; }
		private TreeNode _result = new TreeNode();

		public static string GenerateUrls(Assembly controllerAssembly)
		{
			UrlGenerator generator = new UrlGenerator();

			generator.ControllerAssembly = controllerAssembly;
			generator.BaseUrl = VirtualPathUtility.ToAbsolute("~");

			return generator.Generate();
		}

		public string Generate()
		{
			List<ControllerInfo> controllers = this.ControllerAssembly.GetTypes()
					.Where(type => typeof(System.Web.Mvc.Controller).IsAssignableFrom(type) && !type.IsAbstract)
					.Select(x => new ControllerInfo()
					{
						Controller = x,
						RouteAttribute = x.GetCustomAttribute(typeof(RouteAttribute)) as RouteAttribute
					})
					.OrderByDescending(x => x.Areas.Length).ThenBy(x => x.Route)
					.ToList();

			_result = GetNode(0, controllers);

			return "var URLs = " + _result.GetUrls(this.BaseUrl) + ";";
		}

		private TreeNode GetNode(int level, List<ControllerInfo> controllers)
		{
			TreeNode result = new TreeNode();

			List<IGrouping<string, ControllerInfo>> group = controllers.GroupBy(x => x.GetArea(level)).ToList();

			if (group.Count > 0)
			{
				foreach (IGrouping<string, ControllerInfo> item in group)
				{
					if (!string.IsNullOrEmpty(item.Key))
					{
						TreeNode node = GetNode(level + 1, item.ToList());

						node.Key = item.Key;

						if (node.Controllers.Count > 0)
						{
							result.Items.Add(node);
						}
						else
						{
							result.Controllers.AddRange(item.ToList());
						}
					}
				}
			}

			return result;

		}

		private class TreeNode
		{
			public string Key { get; set; }
			public List<ControllerInfo> Controllers { get; set; }
			public List<TreeNode> Items { get; set; }

			public TreeNode()
			{
				this.Controllers = new List<ControllerInfo>();
				this.Items = new List<TreeNode>();
			}

			public string GetUrls(string baseUrl)
			{
				StringBuilder sb = new StringBuilder();

				foreach (TreeNode node in this.Items)
				{
					string urls = node.GetUrls(baseUrl);

					if (urls.Length > 0)
					{
						if (sb.Length > 0)
							sb.AppendLine(",");

						sb.Append(urls);
					}
				}

				foreach (ControllerInfo item in this.Controllers)
				{
					// Home is special...
					if (item.ControllerName == "HomeController")
					{
						if (sb.Length > 0)
							sb.AppendLine(",");

						sb.Append("Home: '/'");
                        continue;
					}

					// Any other controller
					string urls = item.GetUrls(baseUrl);

					if (urls.Length > 0)
					{
						if (sb.Length > 0)
							sb.AppendLine(",");

						sb.Append(urls);
					}
				}

				string template = "{{ \n {0}\n}}";

				if (!string.IsNullOrEmpty(this.Key))
					template = "{1}: {{ \n {0}\n}}";

				return string.Format(template, sb, this.Key);
			}
		}

		private class ControllerInfo
		{
			public string ControllerName { get { return this.Controller.Name; } }
			public Type Controller { get; set; }
			public RouteAttribute RouteAttribute { get; set; }
			private string[] _area;

			public string Route
			{
				get
				{
					if (RouteAttribute != null)
					{
						string route = this.RouteAttribute.Template;

						if (route.Contains("/{"))
						{
							var start = route.StartsWith("/") ? 1 : 0;

							route = route.Substring(start, route.LastIndexOf("/{") + 1 - start);
						}
						if (route.StartsWith("{"))
							route = "Home/";

						return route;
					}
					else
						return string.Format("{0}/", this.ControllerName.Substring(0, this.ControllerName.LastIndexOf("Controller")));
				}
			}

			public string[] Areas
			{
				get
				{
					if (_area == null)
					{
						if (this.Route.EndsWith("/"))
							_area = this.Route.Substring(0, this.Route.Length - 1).Split('/');
						else
							_area = this.Route.Split('/');
					}

					return _area;
				}

			}

			public string GetArea(int idx)
			{
				if (idx >= this.Areas.Length)
					return "";
				else
					return this.Areas[idx];
			}

			public string GetUrls(string baseUrl)
			{
				string tabs = "\n";

				int countTab = this.Route.Split('/').Length;

				for (int i = 0; i < countTab; i++)
					tabs += "\t";


				List<string> actions = GetActions();
				StringBuilder urls = new StringBuilder();

				foreach (string action in actions)
				{
					urls.AppendFormat("{3}\t{0}: '{1}{2}{0}',", action, baseUrl, this.Route, tabs);
				}

				if (urls.Length > 0)
					return string.Format("{2}{0}:{{{2}{1}{2}}}", this.Areas.Last(), urls.Remove(urls.Length - 1, 1), tabs);
				else
					return "";
			}

			private List<string> GetActions()
			{

				var list = this.Controller
					.GetMethods(BindingFlags.Public | BindingFlags.DeclaredOnly | BindingFlags.Instance)
					.Where(m => !m.GetCustomAttributes(typeof(System.Runtime.CompilerServices.CompilerGeneratedAttribute), true).Any()
								&& (m.ReturnType.IsSubclassOf(typeof(ActionResult)) || m.ReturnType.IsAssignableFrom(typeof(ActionResult))))
					.Select(x => x.Name)
					.ToList<string>();

				return list.Distinct().ToList();

			}
		}
	}
}