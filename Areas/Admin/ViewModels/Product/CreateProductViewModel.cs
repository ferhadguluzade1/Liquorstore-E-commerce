using Liquorstore_E_commerce.Models;

namespace Liquorstore_E_commerce.Areas.Admin.ViewModels.Product
{
    public class CreateProductViewModel
    {
        public required string ProductImageUrl { get; set; }

     
        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public int BrandId { get; set; }
        public required Brand Brand { get; set; }


        public ICollection<Category> Categories { get; set; } = new List<Category>();


    }
}