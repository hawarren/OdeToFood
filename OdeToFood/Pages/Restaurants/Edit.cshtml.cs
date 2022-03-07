using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Data;
using OdeToFood.Core;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        private readonly IRestaurantData restaurantData;
        public Restaurant restaurant {get; set;}
        public EditModel(IRestaurantData restaurantData){
            this.restaurantData = restaurantData;

        }
        public IActionResult OnGet(int restaurantId)
        {
            restaurant = restaurantData.GetById(restaurantId);
            if (restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
