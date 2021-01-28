using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DB
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime Departures { get; set; }
        public DateTime Arrivals { get; set; }
    }
}
