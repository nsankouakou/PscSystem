using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class StatutDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public ICollection<Bac> Bac { get; set; }

        public ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }

        public string Token { get; set; }

        public static StatutDto FromModel(Statut model)
        {
            return new StatutDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                Bac = model.Bac, 
                HistoriqueJauge = model.HistoriqueJauge, 
            }; 
        }

        public Statut ToModel()
        {
            return new Statut()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                Bac = Bac, 
                HistoriqueJauge = HistoriqueJauge, 
            }; 
        }
    }
}