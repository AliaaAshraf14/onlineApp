using Microsoft.AspNetCore.Mvc;
using OnlineFood_Project.Models;

namespace OnlineFood_Project.Controllers
{
    public class MenuController : Controller
    {
        private OnlineContext context;
        public MenuController()
        {
            context = new OnlineContext();
        }
        public IActionResult Index()
        {
            List<Menu> menus = context.menus.ToList();
            return View(menus);
        }

    }
}
