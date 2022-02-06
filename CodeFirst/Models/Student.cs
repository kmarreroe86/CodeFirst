using System;

namespace CodeFirst.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsBonafied { get; set; }

        public string  ContactNo { get; set; }


        // navigation properties
        public virtual Programme Programme { get; set; }
        public virtual Address Address { get; set; }
    }
}