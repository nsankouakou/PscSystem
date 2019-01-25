using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CaracteristiqueProduit
    {
        public int Id { get; set; }
        public int? IdProduit { get; set; }
        public int? IdCaracteristique { get; set; }
        public int? IdUnite { get; set; }
        public double? Valeur { get; set; }
        public int? StatusCode { get; set; }

        public virtual Caracteristique IdCaracteristiqueNavigation { get; set; }
        public virtual Produit IdProduitNavigation { get; set; }
        public virtual UniteMesure IdUniteNavigation { get; set; }
    }
}
