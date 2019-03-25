using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Person
    {
        public Person()
        {
            Account = new HashSet<Account>();
            Insurance = new HashSet<Insurance>();
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public bool? Gender { get; set; }
        public int AddressId { get; set; }
        public int? Phone { get; set; }

        public virtual Address Address { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<Insurance> Insurance { get; set; }
    }
}
