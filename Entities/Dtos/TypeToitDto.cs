using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class TypeToitDto
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public DateTime? DateCreation { get; set; }

        public short? CorrectionDueAuToit { get; set; }

        public int? StatusCode { get; set; }

        public ICollection<Bac> Bac { get; set; }

        public string Token { get; set; }

        public static TypeToitDto FromModel(TypeToit model)
        {
            return new TypeToitDto()
            {
                Id = model.Id, 
                Libelle = model.Libelle, 
                DateCreation = model.DateCreation, 
                CorrectionDueAuToit = model.CorrectionDueAuToit, 
                StatusCode = model.StatusCode, 
                Bac = model.Bac, 
            }; 
        }

        public TypeToit ToModel()
        {
            return new TypeToit()
            {
                Id = Id, 
                Libelle = Libelle, 
                DateCreation = DateCreation, 
                CorrectionDueAuToit = CorrectionDueAuToit, 
                StatusCode = StatusCode, 
                Bac = Bac, 
            }; 
        }
    }
}