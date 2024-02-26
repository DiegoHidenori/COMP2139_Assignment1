using Microsoft.EntityFrameworkCore;
using COMP2139_Assignment1.Models;

namespace COMP2139_Assignment1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
