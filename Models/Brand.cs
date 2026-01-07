using Liquorstore_E_commerce.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace Liquorstore_E_commerce.Models
{
    public class Brand : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
