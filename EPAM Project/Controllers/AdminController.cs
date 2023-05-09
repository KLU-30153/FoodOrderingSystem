using Microsoft.AspNetCore.Mvc;
using EPAM_Project.Models;
using System.Threading.Tasks;

namespace EPAM_Project.Controllers
{
    public class AdminController : Controller
    {
        // Action method for showing the login page
        public ActionResult AdminLogin()
        {
            return View("AdminLogin");
        }

        // Action method for processing the login form
        [HttpPost]
        public ActionResult AdminLogin(AdminLoginViewModel model)
        {
            if (model.Username == "admin" && model.Password == "Admin@2002")
            {
                // Successful login
                return RedirectToAction("Index", "registers");
            }
            else
            {
                // Incorrect login credentials
                ModelState.AddModelError("", "Incorrect username or password.");
                return View("AdminLogin");
            }
        }
    }
}
