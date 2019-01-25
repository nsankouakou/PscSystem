using System;
using System.Linq;

namespace Entities.Models.Dto
{
    public class MenuDto
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

        public string Token { get; set; }

        public static MenuDto FromModel(Menu model)
        {
            return new MenuDto()
            {
                Id = model.Id, 
                FonctionaliteId = model.FonctionaliteId, 
                LibelleMenu = model.LibelleMenu, 
                Action = model.Action, 
                IdParent = model.IdParent, 
                OrdreMenu = model.OrdreMenu, 
                Controlleur = model.Controlleur, 
                Url = model.Url, 
                Icon = model.Icon, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public Menu ToModel()
        {
            return new Menu()
            {
                Id = Id, 
                FonctionaliteId = FonctionaliteId, 
                LibelleMenu = LibelleMenu, 
                Action = Action, 
                IdParent = IdParent, 
                OrdreMenu = OrdreMenu, 
                Controlleur = Controlleur, 
                Url = Url, 
                Icon = Icon, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}