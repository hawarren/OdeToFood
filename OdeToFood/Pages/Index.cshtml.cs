using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using OdeToFood.Pages.Restaurants;

namespace OdeToFood.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private string myTitle;


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string MyTitle { get => myTitle; set => myTitle = value; }

        public void OnGet()
        {
            MyTitle = "My custom home page";

        }
    }
}
