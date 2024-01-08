using Microsoft.AspNetCore.Mvc;

namespace THBuoi2.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
