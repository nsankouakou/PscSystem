using System;
using System.Linq;

namespace Entities.Models.Dto
{
    public class ReceptionProduitDto
    {
        public int Id { get; set; }

        public int? IdProduit { get; set; }

        public int? IdBac { get; set; }

        public DateTime? DateReception { get; set; }

        public string Operateur { get; set; }

        public string Provenance { get; set; }

        public double? HauteurAvant { get; set; }

        public double? VolumeAvant { get; set; }

        public double? VoulumeCreuxAvant { get; set; }

        public double? HauteurCreuxAvant { get; set; }

        public double? HauteurApres { get; set; }

        public double? VolumeApres { get; set; }

        public double? VolumeCreuxApres { get; set; }

        public double? HauteurCreuxApres { get; set; }

        public double? Temperature { get; set; }

        public DateTime? DateCreation { get; set; }

        public int? CreerPar { get; set; }

        public int? ModifierPar { get; set; }

        public DateTime? DateModification { get; set; }

        public double? DensiteAQuinze { get; set; }

        public double? Vcf { get; set; }

        public double? NsvAvant { get; set; }

        public double? VolumeRecu { get; set; }

        public double? NsvApres { get; set; }

        public short? CreateJauge { get; set; }

        public int? IdJaugeCree { get; set; }

        public double? GsvAvant { get; set; }

        public double? GsvApres { get; set; }

        public double? PiedEauAvant { get; set; }

        public double? PiedEauApres { get; set; }

        public double? BswAvant { get; set; }

        public double? BswApres { get; set; }

        public double? DensiteQuizeAvant { get; set; }

        public double? TemperatureAvant { get; set; }

        public double? CorrectToitAvant { get; set; }

        public double? CorrectToitApres { get; set; }

        public double? VolumeEauAvant { get; set; }

        public double? VolumeEauApres { get; set; }

        public string Observation { get; set; }

        public int? StatusCode { get; set; }

        public BacDto IdBacNavigation { get; set; }

        public ProduitDto IdProduitNavigation { get; set; }

        public string Token { get; set; }

        public static ReceptionProduitDto FromModel(ReceptionProduit model)
        {
            return new ReceptionProduitDto()
            {
                Id = model.Id, 
                IdProduit = model.IdProduit, 
                IdBac = model.IdBac, 
                DateReception = model.DateReception, 
                Operateur = model.Operateur, 
                Provenance = model.Provenance, 
                HauteurAvant = model.HauteurAvant, 
                VolumeAvant = model.VolumeAvant, 
                VoulumeCreuxAvant = model.VoulumeCreuxAvant, 
                HauteurCreuxAvant = model.HauteurCreuxAvant, 
                HauteurApres = model.HauteurApres, 
                VolumeApres = model.VolumeApres, 
                VolumeCreuxApres = model.VolumeCreuxApres, 
                HauteurCreuxApres = model.HauteurCreuxApres, 
                Temperature = model.Temperature, 
                DateCreation = model.DateCreation, 
                CreerPar = model.CreerPar, 
                ModifierPar = model.ModifierPar, 
                DateModification = model.DateModification, 
                DensiteAQuinze = model.DensiteAQuinze, 
                Vcf = model.Vcf, 
                NsvAvant = model.NsvAvant, 
                VolumeRecu = model.VolumeRecu, 
                NsvApres = model.NsvApres, 
                CreateJauge = model.CreateJauge, 
                IdJaugeCree = model.IdJaugeCree, 
                GsvAvant = model.GsvAvant, 
                GsvApres = model.GsvApres, 
                PiedEauAvant = model.PiedEauAvant, 
                PiedEauApres = model.PiedEauApres, 
                BswAvant = model.BswAvant, 
                BswApres = model.BswApres, 
                DensiteQuizeAvant = model.DensiteQuizeAvant, 
                TemperatureAvant = model.TemperatureAvant, 
                CorrectToitAvant = model.CorrectToitAvant, 
                CorrectToitApres = model.CorrectToitApres, 
                VolumeEauAvant = model.VolumeEauAvant, 
                VolumeEauApres = model.VolumeEauApres, 
                Observation = model.Observation, 
                StatusCode = model.StatusCode, 
                IdBacNavigation = BacDto.FromModel(model.IdBacNavigation), 
                IdProduitNavigation = ProduitDto.FromModel(model.IdProduitNavigation), 
            }; 
        }

        public ReceptionProduit ToModel()
        {
            return new ReceptionProduit()
            {
                Id = Id, 
                IdProduit = IdProduit, 
                IdBac = IdBac, 
                DateReception = DateReception, 
                Operateur = Operateur, 
                Provenance = Provenance, 
                HauteurAvant = HauteurAvant, 
                VolumeAvant = VolumeAvant, 
                VoulumeCreuxAvant = VoulumeCreuxAvant, 
                HauteurCreuxAvant = HauteurCreuxAvant, 
                HauteurApres = HauteurApres, 
                VolumeApres = VolumeApres, 
                VolumeCreuxApres = VolumeCreuxApres, 
                HauteurCreuxApres = HauteurCreuxApres, 
                Temperature = Temperature, 
                DateCreation = DateCreation, 
                CreerPar = CreerPar, 
                ModifierPar = ModifierPar, 
                DateModification = DateModification, 
                DensiteAQuinze = DensiteAQuinze, 
                Vcf = Vcf, 
                NsvAvant = NsvAvant, 
                VolumeRecu = VolumeRecu, 
                NsvApres = NsvApres, 
                CreateJauge = CreateJauge, 
                IdJaugeCree = IdJaugeCree, 
                GsvAvant = GsvAvant, 
                GsvApres = GsvApres, 
                PiedEauAvant = PiedEauAvant, 
                PiedEauApres = PiedEauApres, 
                BswAvant = BswAvant, 
                BswApres = BswApres, 
                DensiteQuizeAvant = DensiteQuizeAvant, 
                TemperatureAvant = TemperatureAvant, 
                CorrectToitAvant = CorrectToitAvant, 
                CorrectToitApres = CorrectToitApres, 
                VolumeEauAvant = VolumeEauAvant, 
                VolumeEauApres = VolumeEauApres, 
                Observation = Observation, 
                StatusCode = StatusCode, 
                IdBacNavigation = IdBacNavigation.ToModel(), 
                IdProduitNavigation = IdProduitNavigation.ToModel(), 
            }; 
        }
    }
}