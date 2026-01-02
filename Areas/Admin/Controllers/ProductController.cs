using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
