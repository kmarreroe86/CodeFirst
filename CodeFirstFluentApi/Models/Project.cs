using System.Collections.Generic;

namespace CodeFirstFluentApi.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Language { get; set; }

        public string Database { get; set; }

        
        /* Navigation Props */
        public virtual ICollection<Employee> Employees { get; set; }
        
    }
}