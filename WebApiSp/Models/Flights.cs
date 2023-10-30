using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSp.Models
{
    public class Flights
    {
        [Key]
        public int FlightID { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirport { get; set;  }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AircraftID { get; set; }
    }
}
