using QRCodeAPI.Models;
using System.Web.Http;

namespace QRCodeAPI
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Basic Authentication for website
			config.Filters.Add(new BasicAuthenticationAttribute());
			
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{text}",
				defaults: new { text = RouteParameter.Optional }
			);
		}
	}
}
