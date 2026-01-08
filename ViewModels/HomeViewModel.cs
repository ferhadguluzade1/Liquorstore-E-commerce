using Liquorstore_E_commerce.Models;


namespace Liquorstore_E_commerce.ViewModels
{
    public record HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<Product> Products { get; set; }

    }
}
