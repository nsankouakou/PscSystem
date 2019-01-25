using System;

namespace Entities.Models.Dto
{
    public class ProduitBacDto
    {
        public int Id { get; set; }

        public int? IdProduit { get; set; }

        public int? IdBac { get; set; }

        public short? Actif { get; set; }

        public double? HauteurMesure { get; set; }

        public int? IdUnite { get; set; }

        public DateTime? DateCreation { get; set; }

        public double? Temperature { get; set; }

        public double? DensiteAQuize { get; set; }

        public double? VolumeMesure { get; set; }

        public double? Bsw { get; set; }

        public double? PiedEau { get; set; }

        public double? VolumeEau { get; set; }

        public double? Vcf { get; set; }

        public double? CorrectToit { get; set; }

        public double? DensiteAT { get; set; }

        public DateTime? DateModification { get; set; }

        public int? StatusCode { get; set; }

        public BacDto IdBacNavigation { get; set; }

        public ProduitDto IdProduitNavigation { get; set; }

        public UniteMesureDto IdUniteNavigation { get; set; }

        public string Token { get; set; }

        public static ProduitBacDto FromModel(ProduitBac model)
        {
            return new ProduitBacDto()
            {
                Id = model.Id, 
                IdProduit = model.IdProduit, 
                IdBac = model.IdBac, 
                Actif = model.Actif, 
                HauteurMesure = model.HauteurMesure, 
                IdUnite = model.IdUnite, 
                DateCreation = model.DateCreation, 
                Temperature = model.Temperature, 
                DensiteAQuize = model.DensiteAQuize, 
                VolumeMesure = model.VolumeMesure, 
                Bsw = model.Bsw, 
                PiedEau = model.PiedEau, 
                VolumeEau = model.VolumeEau, 
                Vcf = model.Vcf, 
                CorrectToit = model.CorrectToit, 
                DensiteAT = model.DensiteAT, 
                DateModification = model.DateModification, 
                StatusCode = model.StatusCode, 
                IdBacNavigation = BacDto.FromModel(model.IdBacNavigation), 
                IdProduitNavigation = ProduitDto.FromModel(model.IdProduitNavigation), 
                IdUniteNavigation = UniteMesureDto.FromModel(model.IdUniteNavigation), 
            }; 
        }

        public ProduitBac ToModel()
        {
            return new ProduitBac()
            {
                Id = Id, 
                IdProduit = IdProduit, 
                IdBac = IdBac, 
                Actif = Actif, 
                HauteurMesure = HauteurMesure, 
                IdUnite = IdUnite, 
                DateCreation = DateCreation, 
                Temperature = Temperature, 
                DensiteAQuize = DensiteAQuize, 
                VolumeMesure = VolumeMesure, 
                Bsw = Bsw, 
                PiedEau = PiedEau, 
                VolumeEau = VolumeEau, 
                Vcf = Vcf, 
                CorrectToit = CorrectToit, 
                DensiteAT = DensiteAT, 
                DateModification = DateModification, 
                StatusCode = StatusCode, 
                IdBacNavigation = IdBacNavigation.ToModel(), 
                IdProduitNavigation = IdProduitNavigation.ToModel(), 
                IdUniteNavigation = IdUniteNavigation.ToModel(), 
            }; 
        }
    }
}