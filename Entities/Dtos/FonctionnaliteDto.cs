using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class FonctionnaliteDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<ProfilFonctionnalite> ProfilFonctionnalite { get; set; }

        public string Token { get; set; }

        public static FonctionnaliteDto FromModel(Fonctionnalite model)
        {
            return new FonctionnaliteDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                StatusCode = model.StatusCode, 
                ProfilFonctionnalite = model.ProfilFonctionnalite, 
            }; 
        }

        public Fonctionnalite ToModel()
        {
            return new Fonctionnalite()
            {
                Id = Id, 
                Libelle = Libelle, 
                StatusCode = StatusCode, 
                ProfilFonctionnalite = ProfilFonctionnalite, 
            }; 
        }
    }
}