using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodHUB1.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> product { get; set; }
        public virtual List<Review> review { get; set; }
    }
}