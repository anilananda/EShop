using EShop.Model;
using Microsoft.EntityFrameworkCore;

namespace EShop.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }


    }
}
