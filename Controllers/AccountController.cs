using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
