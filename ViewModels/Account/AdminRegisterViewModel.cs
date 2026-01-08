using System.ComponentModel.DataAnnotations;
namespace Liquorstore_E_commerce.ViewModels.Account
{
    public record AdminRegisterViewModel
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
