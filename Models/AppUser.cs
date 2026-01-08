using Microsoft.AspNetCore.Identity;

namespace Liquorstore_E_commerce.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
