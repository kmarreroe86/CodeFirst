using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Programme
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }

        public float Fees { get; set; }


        // navigation properties
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<ProgrammeSubject> ProgrammeSubjects { get; set; }
    }
}