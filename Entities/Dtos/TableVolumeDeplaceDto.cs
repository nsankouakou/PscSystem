using System;

namespace Entities.Models.Dto
{
    public class TableVolumeDeplaceDto
    {
        public int Id { get; set; }

        public double? Ligne { get; set; }

        public double? Colonne { get; set; }

        public double? VolumeDeplace { get; set; }

        public int? IdBac { get; set; }

        public int? StatusCode { get; set; }

        public BacDto IdBacNavigation { get; set; }

        public string Token { get; set; }

        public static TableVolumeDeplaceDto FromModel(TableVolumeDeplace model)
        {
            return new TableVolumeDeplaceDto()
            {
                Id = model.Id, 
                Ligne = model.Ligne, 
                Colonne = model.Colonne, 
                VolumeDeplace = model.VolumeDeplace, 
                IdBac = model.IdBac, 
                StatusCode = model.StatusCode, 
                IdBacNavigation = BacDto.FromModel(model.IdBacNavigation), 
            }; 
        }

        public TableVolumeDeplace ToModel()
        {
            return new TableVolumeDeplace()
            {
                Id = Id, 
                Ligne = Ligne, 
                Colonne = Colonne, 
                VolumeDeplace = VolumeDeplace, 
                IdBac = IdBac, 
                StatusCode = StatusCode, 
                IdBacNavigation = IdBacNavigation.ToModel(), 
            }; 
        }
    }
}