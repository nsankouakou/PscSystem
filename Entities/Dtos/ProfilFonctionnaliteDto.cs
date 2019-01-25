using System;

namespace Entities.Models.Dto
{
    public class ProfilFonctionnaliteDto
    {
        public int Id { get; set; }

        public int? IdProfil { get; set; }

        public int? IdFonctionnalite { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? StatusCode { get; set; }

        public FonctionnaliteDto IdFonctionnaliteNavigation { get; set; }

        public ProfilDto IdProfilNavigation { get; set; }

        public string Token { get; set; }

        public static ProfilFonctionnaliteDto FromModel(ProfilFonctionnalite model)
        {
            return new ProfilFonctionnaliteDto()
            {
                Id = model.Id, 
                IdProfil = model.IdProfil, 
                IdFonctionnalite = model.IdFonctionnalite, 
                DateCreation = model.DateCreation, 
                StatusCode = model.StatusCode, 
                IdFonctionnaliteNavigation = FonctionnaliteDto.FromModel(model.IdFonctionnaliteNavigation), 
                IdProfilNavigation = ProfilDto.FromModel(model.IdProfilNavigation), 
            }; 
        }

        public ProfilFonctionnalite ToModel()
        {
            return new ProfilFonctionnalite()
            {
                Id = Id, 
                IdProfil = IdProfil, 
                IdFonctionnalite = IdFonctionnalite, 
                DateCreation = DateCreation, 
                StatusCode = StatusCode, 
                IdFonctionnaliteNavigation = IdFonctionnaliteNavigation.ToModel(), 
                IdProfilNavigation = IdProfilNavigation.ToModel(), 
            }; 
        }
    }
}