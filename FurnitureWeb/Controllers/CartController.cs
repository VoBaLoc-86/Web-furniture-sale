using Microsoft.AspNetCore.Mvc;

namespace FurnitureWeb.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Checkout() { 
            return View();
        }
        public IActionResult Thankyou() {
            return View();
        }
    }
}
