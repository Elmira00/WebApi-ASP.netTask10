using Microsoft.EntityFrameworkCore;
using WebApi_ASP.netTask9.Entities;

namespace WebApi_ASP.netTask9.DataAccess
{
    public class RetailDbContext : DbContext
    {
        public RetailDbContext(DbContextOptions<RetailDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
