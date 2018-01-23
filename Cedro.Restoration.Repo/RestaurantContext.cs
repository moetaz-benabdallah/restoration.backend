using Cedro.Restoration.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Cedro.Restoration.Repo
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        { }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
    }
}
