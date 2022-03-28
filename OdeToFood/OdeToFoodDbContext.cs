using OdeToFood.Core;
using Microsoft.EntityFrameworkCore;
namespace OdeToFood.Data
{
    public class OdeToFoodDbContext2 : DbContext
    {
        public OdeToFoodDbContext2(DbContextOptions<OdeToFoodDbContext2> options)
        : base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants {get; set;}
    }
}