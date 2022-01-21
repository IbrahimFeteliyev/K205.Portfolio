using Microsoft.AspNetCore.Mvc;

namespace K205.Portfolio.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
