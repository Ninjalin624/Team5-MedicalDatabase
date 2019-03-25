using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int PrescriptionId { get; set; }
        public int OfficeId { get; set; }
        public DateTime? DateArrived { get; set; }
        public DateTime? Created { get; set; }

        public virtual Office Office { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
