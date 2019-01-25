using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Transfert
    {
        public int Id { get; set; }
        public int? IdBacSource { get; set; }
        public int? IdBacDestination { get; set; }
        public double? Hauteur { get; set; }
        public double? Temperature { get; set; }
        public int? IdProduit { get; set; }
        public double? HauteurProduitBacSourceAvant { get; set; }
        public double? HauteurProduitBacDestinationAvant { get; set; }
        public DateTime? DateTransfert { get; set; }
        public DateTime? DateCreation { get; set; }
        public double? VolumeATBacSourceApres { get; set; }
        public double? VolumeATBacDestinationApres { get; set; }
        public int? IdAgent { get; set; }
        public double? VolumeATBacSourceAvant { get; set; }
        public double? VolumeATBacDestinationAvant { get; set; }
        public double? DensiteAQuinzeBacSource { get; set; }
        public double? DensiteAQuinzeBacDestination { get; set; }
        public double? NsvAvantBacSource { get; set; }
        public double? NsvAvantBacDestination { get; set; }
        public double? NsvApresBacSource { get; set; }
        public double? NsvApresBacDestination { get; set; }
        public double? HauteurProduitBacSourceApres { get; set; }
        public double? HauteurProduitBacDestinationApres { get; set; }
        public double? VolumeCreuxBacSourceAvant { get; set; }
        public double? VolumeCreuxBacDestinationAvant { get; set; }
        public double? VolumeCreuxBacSourceApres { get; set; }
        public double? VolumeCreuxBacDestinationApres { get; set; }
        public int? IdJaugeSource { get; set; }
        public int? IdJaugeDestination { get; set; }
        public int? StatusCode { get; set; }

        public virtual Agent IdAgentNavigation { get; set; }
        public virtual Bac IdBacDestinationNavigation { get; set; }
        public virtual Bac IdBacSourceNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
    }
}
