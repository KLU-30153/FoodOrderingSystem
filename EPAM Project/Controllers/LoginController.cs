using Microsoft.AspNetCore.Mvc;
using EPAM_Project.Models;
using System.Threading.Tasks;

namespace EPAM_Project.Controllers
{
	public class LoginController : Controller
	{
		private readonly DatabaseContext _context;

		public LoginController(DatabaseContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				// Check if username and password are valid
				var user = await _context.Registers.FindAsync(model.Username, model.Password);
				if (user != null)
				{
					// Set user session and redirect to home page
					HttpContext.Session.SetInt32("userId", user.Uid);
					return RedirectToAction("Index", "Home");
				}
				else
				{
					ModelState.AddModelError("", "Invalid username or password.");
				}
			}
			return View(model);
		}
	}
}
