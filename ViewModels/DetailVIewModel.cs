using Liquorstore_E_commerce.Models;
namespace Liquorstore_E_commerce.ViewModels
{
    public record DetailViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }

    }
}
