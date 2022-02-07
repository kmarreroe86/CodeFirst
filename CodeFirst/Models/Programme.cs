using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    [Table("course")]
    public class Programme
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]   // Database does not generate the value
        public int Id { get; set; }

        [Required]
        [Column("course_name", TypeName = "varchar(100)")]
        [MaxLength(100)]
        public string Title { get; set; }

        public int Duration { get; set; }

        public float Fees { get; set; }


        // navigation properties
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<ProgrammeSubject> ProgrammeSubjects { get; set; }
    }
}