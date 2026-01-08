using Liquorstore_E_commerce.Models.Base;

namespace Liquorstore_E_commerce.Models
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
