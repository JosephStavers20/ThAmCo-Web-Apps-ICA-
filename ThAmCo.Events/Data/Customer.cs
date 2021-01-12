using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Data
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public List<GuestBooking> Bookings { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string CustomerName { get => FirstName + " " + Surname; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int BookingsCount { get => Bookings.Count; }
    }
}
