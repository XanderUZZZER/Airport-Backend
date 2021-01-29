using System;
using System.ComponentModel.DataAnnotations;

namespace Airport.DB
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
