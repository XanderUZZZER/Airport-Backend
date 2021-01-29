using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DB
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
    }
}
