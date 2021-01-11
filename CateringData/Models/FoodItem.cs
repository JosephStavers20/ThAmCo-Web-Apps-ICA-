using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering
{
    public class FoodItem
    {
        public FoodItem()
        { 
        }
        
        public FoodItem(string description) : this()
        {
            Description = description;
        }

        public int FoodItemId { get; set; }

        [Required]
        public string Description { get; set; }
        public double UnitPrice { get; set; }

        public ICollection<MenuFoodItem> MenuFoodItems { get; set; }


    }
}
