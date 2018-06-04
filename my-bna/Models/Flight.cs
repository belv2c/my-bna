using System;

namespace my_bna.Models
{
    public class Flight
    {
        public int Flight_id { get; set; }
        public int User_id { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime FlightTime { get; set; }
        public string Airline { get; set; }
        public string Confirmation { get; set; }
    }
}