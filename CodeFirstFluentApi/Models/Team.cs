using System.Collections.Generic;

namespace CodeFirstFluentApi.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Size { get; set; }


        /* Navigation Props*/
        public virtual ICollection<Employee> Employees { get; set; }
    }
}