using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class UniteMesure
    {
        public UniteMesure()
        {
            CaracteristiqueProduit = new HashSet<CaracteristiqueProduit>();
            ProduitBac = new HashSet<ProduitBac>();
            ValeurConversionUniteIdUniteDestinationNavigation = new HashSet<ValeurConversionUnite>();
            ValeurConversionUniteIdUniteOrigineNavigation = new HashSet<ValeurConversionUnite>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? IdGrandeur { get; set; }
        public short? IsDefault { get; set; }
        public string Symbole { get; set; }
        public short? EstUniteReference { get; set; }
        public int? StatutCode { get; set; }

        public virtual Grandeur IdGrandeurNavigation { get; set; }
        public virtual ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }
        public virtual ICollection<ProduitBac> ProduitBac { get; set; }
        public virtual ICollection<ValeurConversionUnite> ValeurConversionUniteIdUniteDestinationNavigation { get; set; }
        public virtual ICollection<ValeurConversionUnite> ValeurConversionUniteIdUniteOrigineNavigation { get; set; }
    }
}
