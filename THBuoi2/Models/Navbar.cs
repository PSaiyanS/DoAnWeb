using Microsoft.AspNetCore.Mvc;
using THBuoi2.Database;

namespace Demo.Models
{
	public class Navbar: ViewComponent
	{
		private readonly ApplicationDbContext _context;

		public Navbar(ApplicationDbContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			return View(_context.Categories.ToList());
		}
	}
}
