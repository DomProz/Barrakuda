using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class BarrakudaDbContext : DbContext
    {
        public BarrakudaDbContext(DbContextOptions<BarrakudaDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
