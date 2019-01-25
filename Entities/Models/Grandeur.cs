using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Grandeur
    {
        public Grandeur()
        {
            UniteMesure = new HashSet<UniteMesure>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Symbole { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<UniteMesure> UniteMesure { get; set; }
    }
}
