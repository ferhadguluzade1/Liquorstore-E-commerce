using System.ComponentModel.DataAnnotations;
namespace Liquorstore_E_commerce.ViewModels.Account
{
    public record LoginViewModel
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
