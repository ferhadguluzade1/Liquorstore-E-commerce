using System.ComponentModel.DataAnnotations;
namespace Liquorstore_E_commerce.ViewModels.Account
{
    public record RegisterViewModel
    {
        [Required, MaxLength(25, ErrorMessage = "Name cannot exceed 25 characters")]
        public string Name { get; set; }
        [Required, MaxLength(25, ErrorMessage = "Surname cannot exceed 25 characters")]
        public string Surname { get; set; }
        [Required, MaxLength(25, ErrorMessage = "Username cannot exceed 25 characters")]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
