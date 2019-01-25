using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class TypeProduitDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public ICollection<Produit> Produit { get; set; }

        

        public static TypeProduitDto FromModel(TypeProduit model)
        {
            return new TypeProduitDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                StatusCode = model.StatusCode, 
                Produit = model.Produit, 
            }; 
        }

        public TypeProduit ToModel()
        {
            return new TypeProduit()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                StatusCode = StatusCode, 
                Produit = Produit, 
            }; 
        }
    }
}