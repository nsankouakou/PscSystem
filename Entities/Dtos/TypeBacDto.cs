using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class TypeBacDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<Bac> Bac { get; set; }

        public string Token { get; set; }

        public static TypeBacDto FromModel(TypeBac model)
        {
            return new TypeBacDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                StatusCode = model.StatusCode, 
                Bac = model.Bac, 
            }; 
        }

        public TypeBac ToModel()
        {
            return new TypeBac()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                StatusCode = StatusCode, 
                Bac = Bac, 
            }; 
        }
    }
}