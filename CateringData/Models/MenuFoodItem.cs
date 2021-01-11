using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering
{
    public class MenuFoodItem
    {
        public int MenuId { get; set; }
        public int FoodItemId { get; set; }

        public Menu Menu { get; set; }

        public FoodItem FoodItem { get; set; }

    }
}
