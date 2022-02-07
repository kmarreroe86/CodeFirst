using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Address
    {
        // public int Id { get; set; }

        [Key, ForeignKey("Student")]
        public int StudentId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [NotMapped] // Will exist in database only
        public string ZipCode { get; set; }

        // navigation properties
        public Student Student { get; set; }    // ForeignKey("Student")
    }
}