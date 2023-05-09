using EPAM_Project.Models;
using EPAM_Project.Views.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EPAM_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult PaymentResult()
        {
            return View();
        }
        public IActionResult ViewDetails()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Menupage()
        {
            return View();
        }
        public IActionResult Menu()
        {
            MenuViewModel model = new MenuViewModel();
            model.AddItem(new Item { Name = "Hamburger", Description = "Juicy beef patty with lettuce, tomato and onion", Price = 150.0m });
            model.AddItem(new Item { Name = "Pizza", Description = "Thin crust pizza with tomato sauce, cheese and your choice of toppings", Price = 200.00m });
            model.AddItem(new Item { Name = "Caesar Salad", Description = "Fresh lettuce with croutons, parmesan cheese and Caesar dressing", Price = 100.0m });
            model.AddItem(new Item { Name = "Fish and Chips", Description = "Battered fish served with crispy fries", Price = 250.00m });
            model.AddItem(new Item { Name = "BBQ Ribs", Description = "Slow-cooked pork ribs with BBQ sauce", Price = 120.00m });
            model.AddItem(new Item { Name = "Chicken Alfredo", Description = "Grilled chicken with creamy Alfredo sauce over pasta", Price = 99.00m });
            model.AddItem(new Item { Name = "Veggie Burger", Description = "Plant-based burger with lettuce, tomato and onion", Price = 75.50m });
            model.AddItem(new Item { Name = "Steak Frites", Description = "Grilled steak served with fries and garlic butter", Price = 59.00m });
            model.AddItem(new Item { Name = "Sushi Platter", Description = "Assorted sushi rolls and sashimi", Price = 130.00m });

            return View(model);
        }


        public IActionResult Checkout()
		{
			return View();
		}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}