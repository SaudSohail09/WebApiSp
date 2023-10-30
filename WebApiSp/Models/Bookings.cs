using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSp.Models
{
    public class Bookings
    {
        [Key]
        public int BookingID { get; set; }
        public int PassengerID { get; set; }
        public int FlightID { get; set; }
        public DateTime BookingDate { get; set;  }
        public string SeatNumber { get; set; }
        public string BookingStatus { get; set; }


    }
}
