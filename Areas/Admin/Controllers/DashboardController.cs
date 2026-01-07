using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
