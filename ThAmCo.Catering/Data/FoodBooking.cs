using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering
{
    public class FoodBooking
    {
        public int FoodBookingId{ get; set; }
        public int ClientReferenceId { get; set; }
        public int NumberOfGuests { get; set; }

        [Required]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
                
        
    }
}
