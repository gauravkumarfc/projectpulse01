using EverShop.Models;
using Microsoft.EntityFrameworkCore;

namespace EverShop.Services
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
