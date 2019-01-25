using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class AgentDto
    {
        public int Id { get; set; }

        public int? IdProfil { get; set; }

        public string Login { get; set; }

        public string MotDePasse { get; set; }

        public DateTime? DateCreation { get; set; }

        public string Nom { get; set; }

        public string Prenoms { get; set; }

        public string Contact { get; set; }

        public string Email { get; set; }

        public short? IsUser { get; set; }

        public int? IdPhoto { get; set; }

        public int? StatusCode { get; set; }

        public PhotoDto IdPhotoNavigation { get; set; }

        public ProfilDto IdProfilNavigation { get; set; }

        public ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }

        public ICollection<Transfert> Transfert { get; set; }

        public string Token { get; set; }

        public static AgentDto FromModel(Agent model)
        {
            return new AgentDto()
            {
                Id = model.Id, 
                IdProfil = model.IdProfil, 
                Login = model.Login, 
                MotDePasse = model.MotDePasse, 
                DateCreation = model.DateCreation, 
                Nom = model.Nom, 
                Prenoms = model.Prenoms, 
                Contact = model.Contact, 
                Email = model.Email, 
                IsUser = model.IsUser, 
                IdPhoto = model.IdPhoto, 
                StatusCode = model.StatusCode, 
                IdPhotoNavigation = PhotoDto.FromModel(model.IdPhotoNavigation), 
                IdProfilNavigation = ProfilDto.FromModel(model.IdProfilNavigation), 
                HistoriqueJauge = model.HistoriqueJauge, 
                Transfert = model.Transfert, 
            }; 
        }

        public Agent ToModel()
        {
            return new Agent()
            {
                Id = Id, 
                IdProfil = IdProfil, 
                Login = Login, 
                MotDePasse = MotDePasse, 
                DateCreation = DateCreation, 
                Nom = Nom, 
                Prenoms = Prenoms, 
                Contact = Contact, 
                Email = Email, 
                IsUser = IsUser, 
                IdPhoto = IdPhoto, 
                StatusCode = StatusCode, 
                IdPhotoNavigation = IdPhotoNavigation.ToModel(), 
                IdProfilNavigation = IdProfilNavigation.ToModel(), 
                HistoriqueJauge = HistoriqueJauge, 
                Transfert = Transfert, 
            }; 
        }
    }
}