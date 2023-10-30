using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSp.Models
{
    public class Passengers
    {
        [Key]
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public DateTime DateOfBirth { get; set; }
        public string PassportID { get; set; }
        public string ContactInformation { get; set; }
    }
}
