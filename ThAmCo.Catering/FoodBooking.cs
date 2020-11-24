using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering
{
    public class FoodBooking
    {
        public int FoodBookingID{ get; set; }
        public int ClientReferenceID { get; set; }
        public int NumberOfGuests { get; set; }
        public Menu MenuID { get; set; }

    }
}
