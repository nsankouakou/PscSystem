using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class PlageDensiteTemperature
    {
        public int Id { get; set; }
        public double? DensiteAQuinzeMin { get; set; }
        public double? DensiteAQuinzeMax { get; set; }
        public double? TemperatureMin { get; set; }
        public double? TemperatureMax { get; set; }
        public short? PourPetroleBrut { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? StatusCode { get; set; }
    }
}
