using System;

namespace AspNet5StartApp.Models
{
    public class Person : ModelBase
    {
        public string FirstName { get; set; }

        public string MiddleNames { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public Address Address { get; set; } 
    }
}