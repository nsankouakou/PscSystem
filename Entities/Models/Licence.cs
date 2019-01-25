using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Licence
    {
        public int Id { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }
        public int? NombreJour { get; set; }
        public string Module { get; set; }
        public DateTime? DateCreation { get; set; }
        public short? IsActive { get; set; }
        public int? StatusCode { get; set; }
    }
}
