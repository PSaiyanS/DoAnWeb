using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace THBuoi2.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = "ADMIN")]
	[Route("admin")]

    public class AdminController : Controller
	{
		[Route ("")]
		[Route("Index")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
