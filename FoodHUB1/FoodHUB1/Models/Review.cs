using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodHUB1.Models
{
    public class Review
    {
        
        public virtual int Id { get; set; }
        public string comment { get; set; }
        public int stars { get; set; }
        public  int RestaurantId { get; set; }
        public Restaurant restaurant { get; set; }
            
    }
}