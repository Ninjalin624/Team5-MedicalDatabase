using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Address
    {
        public Address()
        {
            Office = new HashSet<Office>();
            Person = new HashSet<Person>();
        }

        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public virtual ICollection<Office> Office { get; set; }
        public virtual ICollection<Person> Person { get; set; }
    }
}
