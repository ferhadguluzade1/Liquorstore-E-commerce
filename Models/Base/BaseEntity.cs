using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Models.Base
{
    public class BaseEntity : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
