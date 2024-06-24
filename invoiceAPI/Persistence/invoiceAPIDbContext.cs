using invoiceAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace invoiceAPI.Persistence
{
    public class invoiceAPIDbContext(DbContextOptions<invoiceAPIDbContext> options) : DbContext(options)
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
