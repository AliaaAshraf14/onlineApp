using Microsoft.AspNetCore.Mvc;

namespace OnlineFood_Project.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string clientName)
        {
            return Redirect("Home/Index");
        }
    }
}
