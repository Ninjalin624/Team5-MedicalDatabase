using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public int? InsuranceId { get; set; }
        public int? PrimaryOfficeId { get; set; }
        public int? BloodTypeId { get; set; }

        public virtual BloodType BloodType { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual Person Person { get; set; }
        public virtual Office PrimaryOffice { get; set; }
    }
}
