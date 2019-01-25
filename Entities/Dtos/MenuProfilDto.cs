using System;

namespace Entities.Models.Dto
{
    public class MenuProfilDto
    {
        public int Menuid { get; set; }

        public int Profilid { get; set; }

        public string Token { get; set; }

        public static MenuProfilDto FromModel(MenuProfil model)
        {
            return new MenuProfilDto()
            {
                Menuid = model.Menuid, 
                Profilid = model.Profilid, 
            }; 
        }

        public MenuProfil ToModel()
        {
            return new MenuProfil()
            {
                Menuid = Menuid, 
                Profilid = Profilid, 
            }; 
        }
    }
}