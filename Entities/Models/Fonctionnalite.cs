using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Fonctionnalite
    {
        public Fonctionnalite()
        {
            ProfilFonctionnalite = new HashSet<ProfilFonctionnalite>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<ProfilFonctionnalite> ProfilFonctionnalite { get; set; }
    }
}
