using Liquorstore_E_commerce.Models;
using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Mvc;

namespace Liquorstore_E_commerce.DAL
{
    public class LiquorStoreDbContext : DbContext
    {
        public LiquorStoreDbContext(DbContextOptions<LiquorStoreDbContext> options) : base(options)
        {
        }
    }
}
