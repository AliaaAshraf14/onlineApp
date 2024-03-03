
using Microsoft.EntityFrameworkCore;

namespace OnlineFood_Project.Models
{
    public class OnlineContext : DbContext
    {
        public OnlineContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FoodDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Client> clients { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<OrderDetaile> orderDetailes { get; set; }

    }
}
