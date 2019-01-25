using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class ProfilDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<Agent> Agent { get; set; }

        public ICollection<ProfilFonctionnalite> ProfilFonctionnalite { get; set; }

        public string Token { get; set; }

        public static ProfilDto FromModel(Profil model)
        {
            return new ProfilDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                StatusCode = model.StatusCode, 
                Agent = model.Agent, 
                ProfilFonctionnalite = model.ProfilFonctionnalite, 
            }; 
        }

        public Profil ToModel()
        {
            return new Profil()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                StatusCode = StatusCode, 
                Agent = Agent, 
                ProfilFonctionnalite = ProfilFonctionnalite, 
            }; 
        }
    }
}