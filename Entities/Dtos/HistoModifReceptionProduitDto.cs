using System;
using System.Linq;

namespace Entities.Models.Dto
{
    public class HistoModifReceptionProduitDto
    {
        public int Id { get; set; }

        public int? IdReception { get; set; }

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

        public int? IdAgent { get; set; }

        public int? IdBac { get; set; }

        public int? IdProduit { get; set; }

        public DateTime? DateModification { get; set; }

        public double? DensiteAQuinze { get; set; }

        public double? Vcf { get; set; }

        public double? Nsv { get; set; }

        public double? VolumeRecu { get; set; }

        public double? NsvApres { get; set; }

        public short? CreateJauge { get; set; }

        public int? IdJaugeCree { get; set; }

        public double? NsvAvant { get; set; }

        public double? GsvAvant { get; set; }

        public double? GsvApres { get; set; }

        public double? PiedEauAvant { get; set; }

        public double? PiedEauApres { get; set; }

        public double? BswAvant { get; set; }

        public double? BswApres { get; set; }

        public double? DensiteQuizeAvant { get; set; }

        public double? CorrectToitAvant { get; set; }

        public double? CorrectToitApres { get; set; }

        public double? VolumeEauAvant { get; set; }

        public double? VolumeEauApres { get; set; }

        public string Observation { get; set; }

        public double? TemperatureAvant { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public static HistoModifReceptionProduitDto FromModel(HistoModifReceptionProduit model)
        {
            return new HistoModifReceptionProduitDto()
            {
                Id = model.Id, 
                IdReception = model.IdReception, 
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
                IdAgent = model.IdAgent, 
                IdBac = model.IdBac, 
                IdProduit = model.IdProduit, 
                DateModification = model.DateModification, 
                DensiteAQuinze = model.DensiteAQuinze, 
                Vcf = model.Vcf, 
                Nsv = model.Nsv, 
                VolumeRecu = model.VolumeRecu, 
                NsvApres = model.NsvApres, 
                CreateJauge = model.CreateJauge, 
                IdJaugeCree = model.IdJaugeCree, 
                NsvAvant = model.NsvAvant, 
                GsvAvant = model.GsvAvant, 
                GsvApres = model.GsvApres, 
                PiedEauAvant = model.PiedEauAvant, 
                PiedEauApres = model.PiedEauApres, 
                BswAvant = model.BswAvant, 
                BswApres = model.BswApres, 
                DensiteQuizeAvant = model.DensiteQuizeAvant, 
                CorrectToitAvant = model.CorrectToitAvant, 
                CorrectToitApres = model.CorrectToitApres, 
                VolumeEauAvant = model.VolumeEauAvant, 
                VolumeEauApres = model.VolumeEauApres, 
                Observation = model.Observation, 
                TemperatureAvant = model.TemperatureAvant, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public HistoModifReceptionProduit ToModel()
        {
            return new HistoModifReceptionProduit()
            {
                Id = Id, 
                IdReception = IdReception, 
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
                IdAgent = IdAgent, 
                IdBac = IdBac, 
                IdProduit = IdProduit, 
                DateModification = DateModification, 
                DensiteAQuinze = DensiteAQuinze, 
                Vcf = Vcf, 
                Nsv = Nsv, 
                VolumeRecu = VolumeRecu, 
                NsvApres = NsvApres, 
                CreateJauge = CreateJauge, 
                IdJaugeCree = IdJaugeCree, 
                NsvAvant = NsvAvant, 
                GsvAvant = GsvAvant, 
                GsvApres = GsvApres, 
                PiedEauAvant = PiedEauAvant, 
                PiedEauApres = PiedEauApres, 
                BswAvant = BswAvant, 
                BswApres = BswApres, 
                DensiteQuizeAvant = DensiteQuizeAvant, 
                CorrectToitAvant = CorrectToitAvant, 
                CorrectToitApres = CorrectToitApres, 
                VolumeEauAvant = VolumeEauAvant, 
                VolumeEauApres = VolumeEauApres, 
                Observation = Observation, 
                TemperatureAvant = TemperatureAvant, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}