using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Student
    {
        [Key]
        public int RolllNo { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsBonafied { get; set; }

        public string  ContactNo { get; set; }

        // [ForeignKey("Programme")] => Its ok too
        public int ProgrammeId { get; set; }


        /* navigation properties */
        [ForeignKey("ProgrammeId")]
        public virtual Programme Programme { get; set; }

        public virtual Address Address { get; set; }
    }
}