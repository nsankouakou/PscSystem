using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TableVolumeDeplace
    {
        public int Id { get; set; }
        public double? Ligne { get; set; }
        public double? Colonne { get; set; }
        public double? VolumeDeplace { get; set; }
        public int? IdBac { get; set; }
        public int? StatusCode { get; set; }

        public virtual Bac IdBacNavigation { get; set; }
    }
}
