using Liquorstore_E_commerce.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Liquorstore_E_commerce.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductImageUrl { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public List<Category> Categories { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }

    }
}
