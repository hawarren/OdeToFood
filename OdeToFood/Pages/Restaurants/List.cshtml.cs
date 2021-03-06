using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        private readonly ILogger<ListModel> logger;

        public ListModel(IConfiguration config, IRestaurantData restaurantData, ILogger<ListModel> logger)
        {
            this.logger = logger;
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {

            logger.LogError("Executing ListModel");
            //Message = config["Message"];
            Message = config["customMessage"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}
