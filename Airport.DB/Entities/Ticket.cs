using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DB
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
