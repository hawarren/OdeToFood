using System;
using System.Collections.Generic;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        Restaurant GetById(int id);
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant Update(Restaurant updateRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int GetCountOfRestaurant();
        int Commit();
    }



}
