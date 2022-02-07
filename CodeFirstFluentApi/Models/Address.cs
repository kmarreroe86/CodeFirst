namespace CodeFirstFluentApi.Models
{
    public class Address
    {
        public int EmployeeId { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        /* Navigation properties */
        public virtual Employee Employee { get; set; }
    }
}