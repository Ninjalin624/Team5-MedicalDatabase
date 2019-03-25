using System;
using System.Collections.Generic;

namespace ClinicWeb.Model
{
    public partial class Condition
    {
        public Condition()
        {
            Diagnosis = new HashSet<Diagnosis>();
        }

        public int ConditionId { get; set; }
        public string ConditionName { get; set; }
        public string ConditionDescription { get; set; }

        public virtual ICollection<Diagnosis> Diagnosis { get; set; }
    }
}
