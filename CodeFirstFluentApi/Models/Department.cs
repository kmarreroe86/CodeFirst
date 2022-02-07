using System.Collections.Generic;

namespace CodeFirstFluentApi.Models
{
    public class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /* Navigation Props */
        public virtual ICollection<Employee> Employees { get; set; }

    }
}