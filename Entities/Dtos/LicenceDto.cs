using System;
using System.Linq;

namespace Entities.Models.Dto
{
    public class LicenceDto
    {
        public int Id { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public int? NombreJour { get; set; }

        public string Module { get; set; }

        public DateTime? DateCreation { get; set; }

        public short? IsActive { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public static LicenceDto FromModel(Licence model)
        {
            return new LicenceDto()
            {
                Id = model.Id, 
                DateDebut = model.DateDebut, 
                DateFin = model.DateFin, 
                NombreJour = model.NombreJour, 
                Module = model.Module, 
                DateCreation = model.DateCreation, 
                IsActive = model.IsActive, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public Licence ToModel()
        {
            return new Licence()
            {
                Id = Id, 
                DateDebut = DateDebut, 
                DateFin = DateFin, 
                NombreJour = NombreJour, 
                Module = Module, 
                DateCreation = DateCreation, 
                IsActive = IsActive, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}