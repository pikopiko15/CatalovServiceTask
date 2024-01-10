using CatalovService.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalovService.Data
{
    public class CatalogDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options)
        {
        }
    }
}
