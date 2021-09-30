using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Core
{

    public class Restaurant
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Location { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
