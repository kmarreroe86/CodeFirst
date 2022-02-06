using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst.Models
{
    public class ProgrammeSubject
    {
        public int ProgrammeId { get; set; }
        public Programme Programme { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
