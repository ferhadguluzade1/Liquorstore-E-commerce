using Liquorstore_E_commerce.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        LiquorStoreDbContext _context;
        public ProductController(LiquorStoreDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            if (products != null)
            {
                return View(products);
            }
            return View("Null - Error");
        }
    }
}
