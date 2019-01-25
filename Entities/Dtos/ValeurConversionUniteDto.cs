using System;

namespace Entities.Models.Dto
{
    public class ValeurConversionUniteDto
    {
        public int Id { get; set; }

        public int? IdUniteOrigine { get; set; }

        public int? IdUniteDestination { get; set; }

        public double? ValeurConversionOrigine { get; set; }

        public double? ValeurConversionDestination { get; set; }

        public DateTime? DateCreation { get; set; }

        public double? ConstanteConversion { get; set; }

        public int? StatusCode { get; set; }

        public UniteMesureDto IdUniteDestinationNavigation { get; set; }

        public UniteMesureDto IdUniteOrigineNavigation { get; set; }

        public string Token { get; set; }

        public static ValeurConversionUniteDto FromModel(ValeurConversionUnite model)
        {
            return new ValeurConversionUniteDto()
            {
                Id = model.Id, 
                IdUniteOrigine = model.IdUniteOrigine, 
                IdUniteDestination = model.IdUniteDestination, 
                ValeurConversionOrigine = model.ValeurConversionOrigine, 
                ValeurConversionDestination = model.ValeurConversionDestination, 
                DateCreation = model.DateCreation, 
                ConstanteConversion = model.ConstanteConversion, 
                StatusCode = model.StatusCode, 
                IdUniteDestinationNavigation = UniteMesureDto.FromModel(model.IdUniteDestinationNavigation), 
                IdUniteOrigineNavigation = UniteMesureDto.FromModel(model.IdUniteOrigineNavigation), 
            }; 
        }

        public ValeurConversionUnite ToModel()
        {
            return new ValeurConversionUnite()
            {
                Id = Id, 
                IdUniteOrigine = IdUniteOrigine, 
                IdUniteDestination = IdUniteDestination, 
                ValeurConversionOrigine = ValeurConversionOrigine, 
                ValeurConversionDestination = ValeurConversionDestination, 
                DateCreation = DateCreation, 
                ConstanteConversion = ConstanteConversion, 
                StatusCode = StatusCode, 
                IdUniteDestinationNavigation = IdUniteDestinationNavigation.ToModel(), 
                IdUniteOrigineNavigation = IdUniteOrigineNavigation.ToModel(), 
            }; 
        }
    }
}