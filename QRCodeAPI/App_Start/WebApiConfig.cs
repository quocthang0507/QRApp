﻿using System.Web.Http;

namespace QRCodeAPI
{
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
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "ExtendApi",
				routeTemplate: "api/{controller}/{action}/{text}",
				defaults: new { text = RouteParameter.Optional }
			);
		}
	}
}
