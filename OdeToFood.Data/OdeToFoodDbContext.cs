using OdeToFood.Core;
using Microsoft.EntityFrameworkCore;
namespace OdeToFood.Data
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants {get; set;}
    }
}