using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Call_API_MVC.Models
{
    public class FlightViewModel
    {
        public int FlightID { get; set; }
        public string FlightNumber { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public string DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int AircraftID { get; set; }
    }
}
