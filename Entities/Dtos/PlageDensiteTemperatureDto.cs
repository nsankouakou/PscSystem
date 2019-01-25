using System;

namespace Entities.Models.Dto
{
    public class PlageDensiteTemperatureDto
    {
        public int Id { get; set; }

        public double? DensiteAQuinzeMin { get; set; }

        public double? DensiteAQuinzeMax { get; set; }

        public double? TemperatureMin { get; set; }

        public double? TemperatureMax { get; set; }

        public short? PourPetroleBrut { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public static PlageDensiteTemperatureDto FromModel(PlageDensiteTemperature model)
        {
            return new PlageDensiteTemperatureDto()
            {
                Id = model.Id, 
                DensiteAQuinzeMin = model.DensiteAQuinzeMin, 
                DensiteAQuinzeMax = model.DensiteAQuinzeMax, 
                TemperatureMin = model.TemperatureMin, 
                TemperatureMax = model.TemperatureMax, 
                PourPetroleBrut = model.PourPetroleBrut, 
                DateCreation = model.DateCreation, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public PlageDensiteTemperature ToModel()
        {
            return new PlageDensiteTemperature()
            {
                Id = Id, 
                DensiteAQuinzeMin = DensiteAQuinzeMin, 
                DensiteAQuinzeMax = DensiteAQuinzeMax, 
                TemperatureMin = TemperatureMin, 
                TemperatureMax = TemperatureMax, 
                PourPetroleBrut = PourPetroleBrut, 
                DateCreation = DateCreation, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}