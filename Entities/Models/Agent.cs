using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Agent
    {
        public Agent()
        {
            HistoriqueJauge = new HashSet<HistoriqueJauge>();
            Transfert = new HashSet<Transfert>();
        }

        public int Id { get; set; }
        public int? IdProfil { get; set; }
        public string Login { get; set; }
        public string MotDePasse { get; set; }
        public DateTime? DateCreation { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public short? IsUser { get; set; }
        public int? IdPhoto { get; set; }
        public int? StatusCode { get; set; }

        public virtual Photo IdPhotoNavigation { get; set; }
        public virtual Profil IdProfilNavigation { get; set; }
        public virtual ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }
        public virtual ICollection<Transfert> Transfert { get; set; }
    }
}
