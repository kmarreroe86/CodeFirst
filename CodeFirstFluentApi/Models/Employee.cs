using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CodeFirstFluentApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public decimal Salary { get; set; }
        
        public string Email { get; set; }
        
        public string Contact { get; set; }
        
        public string SecondaryContact { get; set; }

        public int ProjectId { get; set; }
        
        
        /* Navigation Props*/
        public virtual Department Department { get; set; }

        public virtual Address Address { get; set; }
        
        public virtual Team Team { get; set; }

        public virtual ICollection<Project> Projects { get; set; }  // TODO: Check if it is ok, or change like ProgrammeSubject
    }
}