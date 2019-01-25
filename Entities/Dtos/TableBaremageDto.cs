using System;

namespace Entities.Models.Dto
{
    public class TableBaremageDto
    {
        public int Id { get; set; }

        public int? Valeur { get; set; }

        public double? Coefficient { get; set; }

        public int? IdIntervalleBaremage { get; set; }

        public int? StatusCode { get; set; }

        public IntervalleBaremageDto IdIntervalleBaremageNavigation { get; set; }

        public string Token { get; set; }

        public static TableBaremageDto FromModel(TableBaremage model)
        {
            return new TableBaremageDto()
            {
                Id = model.Id, 
                Valeur = model.Valeur, 
                Coefficient = model.Coefficient, 
                IdIntervalleBaremage = model.IdIntervalleBaremage, 
                StatusCode = model.StatusCode, 
                IdIntervalleBaremageNavigation = IntervalleBaremageDto.FromModel(model.IdIntervalleBaremageNavigation), 
            }; 
        }

        public TableBaremage ToModel()
        {
            return new TableBaremage()
            {
                Id = Id, 
                Valeur = Valeur, 
                Coefficient = Coefficient, 
                IdIntervalleBaremage = IdIntervalleBaremage, 
                StatusCode = StatusCode, 
                IdIntervalleBaremageNavigation = IdIntervalleBaremageNavigation.ToModel(), 
            }; 
        }
    }
}