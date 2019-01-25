using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ProduitBac
    {
        public int Id { get; set; }
        public int? IdProduit { get; set; }
        public int? IdBac { get; set; }
        public short? Actif { get; set; }
        public double? HauteurMesure { get; set; }
        public int? IdUnite { get; set; }
        public DateTime? DateCreation { get; set; }
        public double? Temperature { get; set; }
        public double? DensiteAQuize { get; set; }
        public double? VolumeMesure { get; set; }
        public double? Bsw { get; set; }
        public double? PiedEau { get; set; }
        public double? VolumeEau { get; set; }
        public double? Vcf { get; set; }
        public double? CorrectToit { get; set; }
        public double? DensiteAT { get; set; }
        public DateTime? DateModification { get; set; }
        public int? StatusCode { get; set; }

        public virtual Bac IdBacNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
        public virtual UniteMesure IdUniteNavigation { get; set; }
    }
}
