using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering
{
    public class Menu
    {
        public int MenuID { get; set; }

        [Required]
        public string MenuName {get; set;}

    }
}
