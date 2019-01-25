using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class UniteMesureDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? IdGrandeur { get; set; }

        public short? IsDefault { get; set; }

        public string Symbole { get; set; }

        public short? EstUniteReference { get; set; }

        public int? StatutCode { get; set; }

        public GrandeurDto IdGrandeurNavigation { get; set; }

        public ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }

        public ICollection<ProduitBac> ProduitBac { get; set; }

        public ICollection<ValeurConversionUnite> ValeurConversionUniteIdUniteDestinationNavigation { get; set; }

        public ICollection<ValeurConversionUnite> ValeurConversionUniteIdUniteOrigineNavigation { get; set; }

        public string Token { get; set; }

        public static UniteMesureDto FromModel(UniteMesure model)
        {
            return new UniteMesureDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                IdGrandeur = model.IdGrandeur, 
                IsDefault = model.IsDefault, 
                Symbole = model.Symbole, 
                EstUniteReference = model.EstUniteReference, 
                StatutCode = model.StatutCode, 
                IdGrandeurNavigation = GrandeurDto.FromModel(model.IdGrandeurNavigation), 
                CaracteristiqueProduit = model.CaracteristiqueProduit, 
                ProduitBac = model.ProduitBac, 
                ValeurConversionUniteIdUniteDestinationNavigation = model.ValeurConversionUniteIdUniteDestinationNavigation, 
                ValeurConversionUniteIdUniteOrigineNavigation = model.ValeurConversionUniteIdUniteOrigineNavigation, 
            }; 
        }

        public UniteMesure ToModel()
        {
            return new UniteMesure()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                IdGrandeur = IdGrandeur, 
                IsDefault = IsDefault, 
                Symbole = Symbole, 
                EstUniteReference = EstUniteReference, 
                StatutCode = StatutCode, 
                IdGrandeurNavigation = IdGrandeurNavigation.ToModel(), 
                CaracteristiqueProduit = CaracteristiqueProduit, 
                ProduitBac = ProduitBac, 
                ValeurConversionUniteIdUniteDestinationNavigation = ValeurConversionUniteIdUniteDestinationNavigation, 
                ValeurConversionUniteIdUniteOrigineNavigation = ValeurConversionUniteIdUniteOrigineNavigation, 
            }; 
        }
    }
}