using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ReceptionProduit
    {
        public int Id { get; set; }
        public int? IdProduit { get; set; }
        public int? IdBac { get; set; }
        public DateTime? DateReception { get; set; }
        public string Operateur { get; set; }
        public string Provenance { get; set; }
        public double? HauteurAvant { get; set; }
        public double? VolumeAvant { get; set; }
        public double? VoulumeCreuxAvant { get; set; }
        public double? HauteurCreuxAvant { get; set; }
        public double? HauteurApres { get; set; }
        public double? VolumeApres { get; set; }
        public double? VolumeCreuxApres { get; set; }
        public double? HauteurCreuxApres { get; set; }
        public double? Temperature { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? CreerPar { get; set; }
        public int? ModifierPar { get; set; }
        public DateTime? DateModification { get; set; }
        public double? DensiteAQuinze { get; set; }
        public double? Vcf { get; set; }
        public double? NsvAvant { get; set; }
        public double? VolumeRecu { get; set; }
        public double? NsvApres { get; set; }
        public short? CreateJauge { get; set; }
        public int? IdJaugeCree { get; set; }
        public double? GsvAvant { get; set; }
        public double? GsvApres { get; set; }
        public double? PiedEauAvant { get; set; }
        public double? PiedEauApres { get; set; }
        public double? BswAvant { get; set; }
        public double? BswApres { get; set; }
        public double? DensiteQuizeAvant { get; set; }
        public double? TemperatureAvant { get; set; }
        public double? CorrectToitAvant { get; set; }
        public double? CorrectToitApres { get; set; }
        public double? VolumeEauAvant { get; set; }
        public double? VolumeEauApres { get; set; }
        public string Observation { get; set; }
        public int? StatusCode { get; set; }

        public virtual Bac IdBacNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
