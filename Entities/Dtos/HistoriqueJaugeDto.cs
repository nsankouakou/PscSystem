using System;
using System.Linq;

namespace Entities.Models.Dto
{
    public class HistoriqueJaugeDto
    {
        public int Id { get; set; }

        public int? IdAgent { get; set; }

        public int? IdBac { get; set; }

        public int? IdProduit { get; set; }

        public DateTime? DateJauge { get; set; }

        public double? HauteurJauge { get; set; }

        public double? Temperature { get; set; }

        public DateTime? DateCreation { get; set; }

        public string Observations { get; set; }

        public double? VolumeJauge { get; set; }

        public double? VolumeCreux { get; set; }

        public double? DensiteAQuize { get; set; }

        public int? IdStatutBac { get; set; }

        public double? Bsw { get; set; }

        public double? PiedEau { get; set; }

        public double? VolumeEau { get; set; }

        public double? Vcf { get; set; }

        public double? CorrectToit { get; set; }

        public double? DensiteAT { get; set; }

        public int? StatusCode { get; set; }

        public AgentDto IdAgentNavigation { get; set; }

        public BacDto IdBacNavigation { get; set; }

        public ProduitDto IdProduitNavigation { get; set; }

        public StatutDto IdStatutBacNavigation { get; set; }

        public string Token { get; set; }

        public static HistoriqueJaugeDto FromModel(HistoriqueJauge model)
        {
            return new HistoriqueJaugeDto()
            {
                Id = model.Id, 
                IdAgent = model.IdAgent, 
                IdBac = model.IdBac, 
                IdProduit = model.IdProduit, 
                DateJauge = model.DateJauge, 
                HauteurJauge = model.HauteurJauge, 
                Temperature = model.Temperature, 
                DateCreation = model.DateCreation, 
                Observations = model.Observations, 
                VolumeJauge = model.VolumeJauge, 
                VolumeCreux = model.VolumeCreux, 
                DensiteAQuize = model.DensiteAQuize, 
                IdStatutBac = model.IdStatutBac, 
                Bsw = model.Bsw, 
                PiedEau = model.PiedEau, 
                VolumeEau = model.VolumeEau, 
                Vcf = model.Vcf, 
                CorrectToit = model.CorrectToit, 
                DensiteAT = model.DensiteAT, 
                StatusCode = model.StatusCode, 
                IdAgentNavigation = AgentDto.FromModel(model.IdAgentNavigation), 
                IdBacNavigation = BacDto.FromModel(model.IdBacNavigation), 
                IdProduitNavigation = ProduitDto.FromModel(model.IdProduitNavigation), 
                IdStatutBacNavigation = StatutDto.FromModel(model.IdStatutBacNavigation), 
            }; 
        }

        public HistoriqueJauge ToModel()
        {
            return new HistoriqueJauge()
            {
                Id = Id, 
                IdAgent = IdAgent, 
                IdBac = IdBac, 
                IdProduit = IdProduit, 
                DateJauge = DateJauge, 
                HauteurJauge = HauteurJauge, 
                Temperature = Temperature, 
                DateCreation = DateCreation, 
                Observations = Observations, 
                VolumeJauge = VolumeJauge, 
                VolumeCreux = VolumeCreux, 
                DensiteAQuize = DensiteAQuize, 
                IdStatutBac = IdStatutBac, 
                Bsw = Bsw, 
                PiedEau = PiedEau, 
                VolumeEau = VolumeEau, 
                Vcf = Vcf, 
                CorrectToit = CorrectToit, 
                DensiteAT = DensiteAT, 
                StatusCode = StatusCode, 
                IdAgentNavigation = IdAgentNavigation.ToModel(), 
                IdBacNavigation = IdBacNavigation.ToModel(), 
                IdProduitNavigation = IdProduitNavigation.ToModel(), 
                IdStatutBacNavigation = IdStatutBacNavigation.ToModel(), 
            }; 
        }
    }
}