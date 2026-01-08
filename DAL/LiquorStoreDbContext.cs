//using Liquorstore_E_commerce.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.DAL
{
    public class LiquorStoreDbContext :/* DbContext*/ IdentityDbContext<AppUser>
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public LiquorStoreDbContext(DbContextOptions<LiquorStoreDbContext> options):base(options){}

    }
}
