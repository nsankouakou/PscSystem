using System;

namespace Entities.Models.Dto
{
    public class CaracteristiqueProduitDto
    {
        public int Id { get; set; }

        public int? IdProduit { get; set; }

        public int? IdCaracteristique { get; set; }

        public int? IdUnite { get; set; }

        public double? Valeur { get; set; }

        public int? StatusCode { get; set; }

        public CaracteristiqueDto IdCaracteristiqueNavigation { get; set; }

        public ProduitDto IdProduitNavigation { get; set; }

        public UniteMesureDto IdUniteNavigation { get; set; }

        public string Token { get; set; }

        public static CaracteristiqueProduitDto FromModel(CaracteristiqueProduit model)
        {
            return new CaracteristiqueProduitDto()
            {
                Id = model.Id, 
                IdProduit = model.IdProduit, 
                IdCaracteristique = model.IdCaracteristique, 
                IdUnite = model.IdUnite, 
                Valeur = model.Valeur, 
                StatusCode = model.StatusCode, 
                IdCaracteristiqueNavigation = CaracteristiqueDto.FromModel(model.IdCaracteristiqueNavigation), 
                IdProduitNavigation = ProduitDto.FromModel(model.IdProduitNavigation), 
                IdUniteNavigation = UniteMesureDto.FromModel(model.IdUniteNavigation), 
            }; 
        }

        public CaracteristiqueProduit ToModel()
        {
            return new CaracteristiqueProduit()
            {
                Id = Id, 
                IdProduit = IdProduit, 
                IdCaracteristique = IdCaracteristique, 
                IdUnite = IdUnite, 
                Valeur = Valeur, 
                StatusCode = StatusCode, 
                IdCaracteristiqueNavigation = IdCaracteristiqueNavigation.ToModel(), 
                IdProduitNavigation = IdProduitNavigation.ToModel(), 
                IdUniteNavigation = IdUniteNavigation.ToModel(), 
            }; 
        }
    }
}