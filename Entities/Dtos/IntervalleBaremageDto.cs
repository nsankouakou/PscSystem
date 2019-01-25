using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class IntervalleBaremageDto
    {
        public int Id { get; set; }

        public double? Debut { get; set; }

        public double? Fin { get; set; }

        public DateTime? DateCreation { get; set; }

        public string SensIntervalleDebut { get; set; }

        public int? IdBac { get; set; }

        public string SensIntervalleFin { get; set; }

        public int? StatusCode { get; set; }

        public BacDto IdBacNavigation { get; set; }

        public ICollection<TableBaremage> TableBaremage { get; set; }

        public string Token { get; set; }

        public static IntervalleBaremageDto FromModel(IntervalleBaremage model)
        {
            return new IntervalleBaremageDto()
            {
                Id = model.Id, 
                Debut = model.Debut, 
                Fin = model.Fin, 
                DateCreation = model.DateCreation, 
                SensIntervalleDebut = model.SensIntervalleDebut, 
                IdBac = model.IdBac, 
                SensIntervalleFin = model.SensIntervalleFin, 
                StatusCode = model.StatusCode, 
                IdBacNavigation = BacDto.FromModel(model.IdBacNavigation), 
                TableBaremage = model.TableBaremage, 
            }; 
        }

        public IntervalleBaremage ToModel()
        {
            return new IntervalleBaremage()
            {
                Id = Id, 
                Debut = Debut, 
                Fin = Fin, 
                DateCreation = DateCreation, 
                SensIntervalleDebut = SensIntervalleDebut, 
                IdBac = IdBac, 
                SensIntervalleFin = SensIntervalleFin, 
                StatusCode = StatusCode, 
                IdBacNavigation = IdBacNavigation.ToModel(), 
                TableBaremage = TableBaremage, 
            }; 
        }
    }
}