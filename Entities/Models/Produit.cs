using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Produit
    {
        public Produit()
        {
            CaracteristiqueProduit = new HashSet<CaracteristiqueProduit>();
            EnvoiProduit = new HashSet<EnvoiProduit>();
            HistoriqueJauge = new HashSet<HistoriqueJauge>();
            ProduitBac = new HashSet<ProduitBac>();
            ReceptionProduit = new HashSet<ReceptionProduit>();
            Transfert = new HashSet<Transfert>();
        }

        public int Id { get; set; }
        public string Designation { get; set; }
        public int? IdTypeProduit { get; set; }
        public DateTime? DateCreation { get; set; }
        public double? DentiteAQuizeMini { get; set; }
        public double? DensiteAQuizeMaxi { get; set; }
        public short? EstPretroleBrut { get; set; }
        public int? StatutCode { get; set; }

        public virtual TypeProduit IdTypeProduitNavigation { get; set; }
        public virtual ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }
        public virtual ICollection<EnvoiProduit> EnvoiProduit { get; set; }
        public virtual ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }
        public virtual ICollection<ProduitBac> ProduitBac { get; set; }
        public virtual ICollection<ReceptionProduit> ReceptionProduit { get; set; }
        public virtual ICollection<Transfert> Transfert { get; set; }
    }
}
