using Microsoft.AspNetCore.Mvc;
using Liquorstore_E_commerce.DAL;
using Liquorstore_E_commerce.Models;

namespace Liquorstore_E_commerce.Controllers
{
    public class HomeController : Controller
    {
        LiquorStoreDbContext _context;
        public HomeController(LiquorStoreDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
