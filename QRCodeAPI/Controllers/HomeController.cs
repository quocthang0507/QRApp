using System.Web.Mvc;

namespace QRCodeAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Title = "QR APIs";

			return View();
		}
	}
}
