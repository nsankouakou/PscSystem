using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class HistoModifJauge
    {
        public int Id { get; set; }
        public int? IdJauge { get; set; }
        public DateTime? DateJauge { get; set; }
        public double? HauteurJauge { get; set; }
        public double? Temperature { get; set; }
        public DateTime? DateCreation { get; set; }
        public string Observations { get; set; }
        public double? VolumeJauge { get; set; }
        public double? VolumeCreux { get; set; }
        public double? DensiteAQuize { get; set; }
        public int? IdAgent { get; set; }
        public int? IdBac { get; set; }
        public int? IdProduit { get; set; }
        public DateTime? DateModification { get; set; }
        public int? IdStatutBac { get; set; }
        public double? Bsw { get; set; }
        public double? PiedEau { get; set; }
        public double? VolumeEau { get; set; }
        public double? Vcf { get; set; }
        public double? CorrectToit { get; set; }
        public double? DensiteAT { get; set; }
        public int? StatusCode { get; set; }
    }
}
