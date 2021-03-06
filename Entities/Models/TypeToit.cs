﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class TypeToit
    {
        public TypeToit()
        {
            Bac = new HashSet<Bac>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime? DateCreation { get; set; }
        public short? CorrectionDueAuToit { get; set; }
        public int? StatusCode { get; set; }

        public virtual ICollection<Bac> Bac { get; set; }
    }
}
