using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class GrandeurDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public string Symbole { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<UniteMesure> UniteMesure { get; set; }

        public string Token { get; set; }

        public static GrandeurDto FromModel(Grandeur model)
        {
            return new GrandeurDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                Symbole = model.Symbole, 
                StatusCode = model.StatusCode, 
                UniteMesure = model.UniteMesure, 
            }; 
        }

        public Grandeur ToModel()
        {
            return new Grandeur()
            {
                Id = Id, 
                Libelle = Libelle, 
                Symbole = Symbole, 
                StatusCode = StatusCode, 
                UniteMesure = UniteMesure, 
            }; 
        }
    }
}