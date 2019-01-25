using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Statut
    {
        public Statut()
        {
            Bac = new HashSet<Bac>();
            HistoriqueJauge = new HashSet<HistoriqueJauge>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }

        public virtual ICollection<Bac> Bac { get; set; }
        public virtual ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }
    }
}
