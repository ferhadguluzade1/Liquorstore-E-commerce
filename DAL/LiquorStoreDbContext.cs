using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.DAL
{
    public class LiquorStoreDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
