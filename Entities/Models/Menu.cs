using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Menu
    {
        public int Id { get; set; }
        public int? FonctionaliteId { get; set; }
        public string LibelleMenu { get; set; }
        public string Action { get; set; }
        public int? IdParent { get; set; }
        public int? OrdreMenu { get; set; }
        public string Controlleur { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public int? StatusCode { get; set; }
    }
}
