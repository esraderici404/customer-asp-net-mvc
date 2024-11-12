using customer.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace customer.Dal
{
    public class CustomerContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-TQ162FD\\SQLEXPRESS; database = customer;integrated security = True");
        }
        public DbSet <Customer> Customers { get; set; }

    }
}
