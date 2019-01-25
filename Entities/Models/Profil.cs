using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Profil
    {
        public Profil()
        {
            Agent = new HashSet<Agent>();
            ProfilFonctionnalite = new HashSet<ProfilFonctionnalite>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Agent> Agent { get; set; }
        public virtual ICollection<ProfilFonctionnalite> ProfilFonctionnalite { get; set; }
    }
}
