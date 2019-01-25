using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Bac
    {
        public Bac()
        {
            EnvoiProduit = new HashSet<EnvoiProduit>();
            HistoriqueJauge = new HashSet<HistoriqueJauge>();
            IntervalleBaremage = new HashSet<IntervalleBaremage>();
            ProduitBac = new HashSet<ProduitBac>();
            ReceptionProduit = new HashSet<ReceptionProduit>();
            TableVolumeDeplace = new HashSet<TableVolumeDeplace>();
            TransfertIdBacDestinationNavigation = new HashSet<Transfert>();
            TransfertIdBacSourceNavigation = new HashSet<Transfert>();
        }

        public int Id { get; set; }
        public string Repere { get; set; }
        public int? IdTypeBac { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int? IdTypeToit { get; set; }
        public DateTime? DateCreation { get; set; }
        public double? Diametre { get; set; }
        public double? VolumeTotal { get; set; }
        public DateTime? DateDerogation { get; set; }
        public int? IdStatut { get; set; }
        public double? HauteurMiniExplotation { get; set; }
        public double? VolumeNonPompable { get; set; }
        public double? TonnageBrut { get; set; }
        public double? TonnageNet { get; set; }
        public double? HauteurTotalReference { get; set; }
        public double? VolumeTheorique { get; set; }
        public double? VolumeReel { get; set; }
        public double? MasseDuToit { get; set; }
        public double? HauteurMiniZoneIncertitude { get; set; }
        public double? HauteurMaxiZoneIncertitude { get; set; }
        public double? HauteurMaximalJauge { get; set; }
        public int? StatusCode { get; set; }

        public virtual Statut IdStatutNavigation { get; set; }
        public virtual TypeBac IdTypeBacNavigation { get; set; }
        public virtual TypeToit IdTypeToitNavigation { get; set; }
        public virtual ICollection<EnvoiProduit> EnvoiProduit { get; set; }
        public virtual ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }
        public virtual ICollection<IntervalleBaremage> IntervalleBaremage { get; set; }
        public virtual ICollection<ProduitBac> ProduitBac { get; set; }
        public virtual ICollection<ReceptionProduit> ReceptionProduit { get; set; }
        public virtual ICollection<TableVolumeDeplace> TableVolumeDeplace { get; set; }
        public virtual ICollection<Transfert> TransfertIdBacDestinationNavigation { get; set; }
        public virtual ICollection<Transfert> TransfertIdBacSourceNavigation { get; set; }
    }
}
