using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Patient
    {
        public Patient()
        {
            Appointment = new HashSet<Appointment>();
            Diagnosis = new HashSet<Diagnosis>();
            MedicalTest = new HashSet<MedicalTest>();
            Prescription = new HashSet<Prescription>();
        }

        public int PatientId { get; set; }
        public int PersonId { get; set; }
        public int? InsuranceId { get; set; }
        public int? PrimaryOfficeId { get; set; }
        public int? BloodTypeId { get; set; }

        public virtual BloodType BloodType { get; set; }
        public virtual Insurance Insurance { get; set; }
        public virtual Person Person { get; set; }
        public virtual Office PrimaryOffice { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Diagnosis> Diagnosis { get; set; }
        public virtual ICollection<MedicalTest> MedicalTest { get; set; }
        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
