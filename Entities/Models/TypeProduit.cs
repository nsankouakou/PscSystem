using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TypeProduit
    {
        public TypeProduit()
        {
            Produit = new HashSet<Produit>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Produit> Produit { get; set; }
    }
}
