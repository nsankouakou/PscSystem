using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class IntervalleBaremage
    {
        public IntervalleBaremage()
        {
            TableBaremage = new HashSet<TableBaremage>();
        }

        public int Id { get; set; }
        public double? Debut { get; set; }
        public double? Fin { get; set; }
        public DateTime? DateCreation { get; set; }
        public string SensIntervalleDebut { get; set; }
        public int? IdBac { get; set; }
        public string SensIntervalleFin { get; set; }
        public int? StatusCode { get; set; }

        public virtual Bac IdBacNavigation { get; set; }
        public virtual ICollection<TableBaremage> TableBaremage { get; set; }
    }
}
