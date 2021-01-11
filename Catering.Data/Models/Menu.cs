using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Data
{
    public class Menu
    {
        //Menu Table
        
        public int MenuId { get; set; }

        [Required]
        public string MenuName {get; set;}

        public ICollection<MenuFoodItem> MenuFoods { get; set; }

        public ICollection<FoodBooking> FoodBookings { get; set; }

    }
}
