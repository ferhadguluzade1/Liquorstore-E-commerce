using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
