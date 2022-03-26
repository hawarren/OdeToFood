using System;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.ViewComponents
{
    public class RestaurantCountViewComponent : ViewComponent
    {
        private readonly IRestaurantData restaurantData;

        public RestaurantCountViewComponent(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        } 

        public IViewComponentResult Invoke()
        {
            //var count = restaurantData.GetCountOfRestaurant();
            var count = restaurantData.GetRestaurantsByName("").ToList();
            return View(count);
        }
    }
}
