using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() { 
            new Restaurant{Id = 1, Name = "Scott's Pizza", Location="Maryland" , Cuisine=CuisineType.Italian },
            new Restaurant{Id = 1, Name = "Curry Shop", Location="Calcutta" , Cuisine=CuisineType.Indian },
            new Restaurant{Id = 1, Name = "Jose's Burritos", Location="Cancun" , Cuisine=CuisineType.Mexican }
            };
        }
        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where String.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
