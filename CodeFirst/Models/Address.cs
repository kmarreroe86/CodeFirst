﻿namespace CodeFirst.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Code { get; set; }

        // navigation properties
        public Student Student { get; set; }
    }
}