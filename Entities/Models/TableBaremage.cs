using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TableBaremage
    {
        public int Id { get; set; }
        public int? Valeur { get; set; }
        public double? Coefficient { get; set; }
        public int? IdIntervalleBaremage { get; set; }
        public int? StatusCode { get; set; }

        public virtual IntervalleBaremage IdIntervalleBaremageNavigation { get; set; }
    }
}
