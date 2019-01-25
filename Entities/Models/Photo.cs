using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Photo
    {
        public Photo()
        {
            Agent = new HashSet<Agent>();
        }

        public int Id { get; set; }
        public string Extension { get; set; }
        public string CheminFichier { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Agent> Agent { get; set; }
    }
}
