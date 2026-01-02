using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
