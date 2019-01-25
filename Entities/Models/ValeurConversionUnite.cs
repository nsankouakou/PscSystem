using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ValeurConversionUnite
    {
        public int Id { get; set; }
        public int? IdUniteOrigine { get; set; }
        public int? IdUniteDestination { get; set; }
        public double? ValeurConversionOrigine { get; set; }
        public double? ValeurConversionDestination { get; set; }
        public DateTime? DateCreation { get; set; }
        public double? ConstanteConversion { get; set; }
        public int? StatusCode { get; set; }

        public virtual UniteMesure IdUniteDestinationNavigation { get; set; }
        public virtual UniteMesure IdUniteOrigineNavigation { get; set; }
    }
}
