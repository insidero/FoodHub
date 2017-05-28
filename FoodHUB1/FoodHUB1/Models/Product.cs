using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodHUB1.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual int RestaurantId { get; set; }
        //public virtual int     ArtistId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string productImageUrl { get; set; }
        public virtual Restaurant restaurant { get; set; }
    }
}