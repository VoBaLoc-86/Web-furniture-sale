using Microsoft.AspNetCore.Mvc;

namespace FurnitureWeb.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
