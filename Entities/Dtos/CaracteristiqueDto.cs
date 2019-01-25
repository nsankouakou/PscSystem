using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class CaracteristiqueDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? GrandeurId { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }

        public string Token { get; set; }

        public static CaracteristiqueDto FromModel(Caracteristique model)
        {
            return new CaracteristiqueDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                GrandeurId = model.GrandeurId, 
                StatusCode = model.StatusCode, 
                CaracteristiqueProduit = model.CaracteristiqueProduit, 
            }; 
        }

        public Caracteristique ToModel()
        {
            return new Caracteristique()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                GrandeurId = GrandeurId, 
                StatusCode = StatusCode, 
                CaracteristiqueProduit = CaracteristiqueProduit, 
            }; 
        }
    }
}