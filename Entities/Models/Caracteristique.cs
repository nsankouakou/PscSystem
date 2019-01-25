using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Caracteristique
    {
        public Caracteristique()
        {
            CaracteristiqueProduit = new HashSet<CaracteristiqueProduit>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? GrandeurId { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }
    }
}
