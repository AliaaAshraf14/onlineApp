using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineFood_Project.Models;

namespace OnlineFood_Project.Controllers
{
    public class OrderController : Controller
    {
        private OnlineContext context;
        public OrderController()
        {
            context = new OnlineContext();
        }
        public IActionResult Index()
        {
            // List<Order> orders = new List<Order>(); 
            return View();
        }
        //get order details
        public IActionResult Details(int id)
        {
            Order order = context.orders.Include(x => x.OrderDetailes).Where(s => s.OrderId == id).SingleOrDefault();
            if (order == null)
            {
                return View("Error");
            }
            return View(order);
        }
        public IActionResult Result()
        {

            return View();

        }

    }
}
