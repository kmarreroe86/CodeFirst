using System.Collections.Generic;
using System.Globalization;

namespace CodeFirst.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Marks { get; set; }

        // navigation properties
        public virtual ICollection<ProgrammeSubject> ProgrammeSubjects { get; set; }
    }
}