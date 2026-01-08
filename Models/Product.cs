using Liquorstore_E_commerce.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Liquorstore_E_commerce.Models
{
    public class Product : BaseEntity
    {
        //    [Required]
        //    public string ProductImageUrl { get; set; }
        //    [Required]
        //    public string Brand { get; set; }
        //    [Required]
        //    public string ProductName { get; set; }
        //    [Required]
        //    public List<Category> Categories { get; set; }
        //    [Required]
        //    public decimal Price { get; set; }
        //    public decimal DiscountPrice { get; set; }

       
            [Required(ErrorMessage = "Product name is required")]
            [StringLength(100, MinimumLength =2, ErrorMessage = "Product name must be between 2 and 100 characters")]
            public required string ProductName { get; set; }

            [Required]
            public required string ProductImageUrl { get; set; }

            [Required(ErrorMessage = "Price is required")]
            [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
            [DataType(DataType.Currency)]
            public decimal Price { get; set; }

            public decimal? DiscountPrice { get; set; }

            public int? BrandId { get; set; }
            public required Brand Brand { get; set; }


            public List<Review> Reviews { get; set; }
            //public ICollection<Category> Categories { get; set; } = new List<Category>();
            [Required(ErrorMessage = "At least one category is required")]
            public List<Category> Categories { get; set; }

            [Required(ErrorMessage = "At least one tag is required")]
            public List<Tag> Tags { get; set; }
    }
}

