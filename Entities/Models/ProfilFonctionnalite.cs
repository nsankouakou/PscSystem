using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ProfilFonctionnalite
    {
        public int Id { get; set; }
        public int? IdProfil { get; set; }
        public int? IdFonctionnalite { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? StatusCode { get; set; }

        public virtual Fonctionnalite IdFonctionnaliteNavigation { get; set; }
        public virtual Profil IdProfilNavigation { get; set; }
    }
}
