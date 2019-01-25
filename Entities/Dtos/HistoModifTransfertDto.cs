using System;

namespace Entities.Models.Dto
{
    public class HistoModifTransfertDto
    {
        public int Id { get; set; }

        public double? Hauteur { get; set; }

        public double? Temperature { get; set; }

        public int? IdTransfert { get; set; }

        public double? HauteurProduitBacSourceAvant { get; set; }

        public double? HauteurProduitBacDestinationAvant { get; set; }

        public DateTime? DateTransfert { get; set; }

        public DateTime? DateCreation { get; set; }

        public double? VolumeATBacSourceApres { get; set; }

        public double? VolumeATBacDestinationApres { get; set; }

        public int? IdAgent { get; set; }

        public int? IdBacSource { get; set; }

        public int? IdBacDestination { get; set; }

        public DateTime? DateModification { get; set; }

        public int? IdProduit { get; set; }

        public double? VolumeATBacSourceAvant { get; set; }

        public double? VolumeATBacDestinationAvant { get; set; }

        public double? DensiteAQuinzeBacSource { get; set; }

        public double? DensiteAQuinzeBacDestination { get; set; }

        public double? NsvAvantBacSource { get; set; }

        public double? NsvAvantBacDestination { get; set; }

        public double? NsvApresBacSource { get; set; }

        public double? NsvApresBacDestination { get; set; }

        public double? HauteurProduitBacSourceApres { get; set; }

        public double? HauteurProduitBacDestinationApres { get; set; }

        public double? VolumeCreuxBacSourceAvant { get; set; }

        public double? VolumeCreuxBacDestinationAvant { get; set; }

        public double? VolumeCreuxBacSourceApres { get; set; }

        public double? VolumeCreuxBacDestinationApres { get; set; }

        public int? IdJaugeSource { get; set; }

        public int? IdJaugeDestination { get; set; }

        public int? StatusCode { get; set; }

        public string Token { get; set; }

        public static HistoModifTransfertDto FromModel(HistoModifTransfert model)
        {
            return new HistoModifTransfertDto()
            {
                Id = model.Id, 
                Hauteur = model.Hauteur, 
                Temperature = model.Temperature, 
                IdTransfert = model.IdTransfert, 
                HauteurProduitBacSourceAvant = model.HauteurProduitBacSourceAvant, 
                HauteurProduitBacDestinationAvant = model.HauteurProduitBacDestinationAvant, 
                DateTransfert = model.DateTransfert, 
                DateCreation = model.DateCreation, 
                VolumeATBacSourceApres = model.VolumeATBacSourceApres, 
                VolumeATBacDestinationApres = model.VolumeATBacDestinationApres, 
                IdAgent = model.IdAgent, 
                IdBacSource = model.IdBacSource, 
                IdBacDestination = model.IdBacDestination, 
                DateModification = model.DateModification, 
                IdProduit = model.IdProduit, 
                VolumeATBacSourceAvant = model.VolumeATBacSourceAvant, 
                VolumeATBacDestinationAvant = model.VolumeATBacDestinationAvant, 
                DensiteAQuinzeBacSource = model.DensiteAQuinzeBacSource, 
                DensiteAQuinzeBacDestination = model.DensiteAQuinzeBacDestination, 
                NsvAvantBacSource = model.NsvAvantBacSource, 
                NsvAvantBacDestination = model.NsvAvantBacDestination, 
                NsvApresBacSource = model.NsvApresBacSource, 
                NsvApresBacDestination = model.NsvApresBacDestination, 
                HauteurProduitBacSourceApres = model.HauteurProduitBacSourceApres, 
                HauteurProduitBacDestinationApres = model.HauteurProduitBacDestinationApres, 
                VolumeCreuxBacSourceAvant = model.VolumeCreuxBacSourceAvant, 
                VolumeCreuxBacDestinationAvant = model.VolumeCreuxBacDestinationAvant, 
                VolumeCreuxBacSourceApres = model.VolumeCreuxBacSourceApres, 
                VolumeCreuxBacDestinationApres = model.VolumeCreuxBacDestinationApres, 
                IdJaugeSource = model.IdJaugeSource, 
                IdJaugeDestination = model.IdJaugeDestination, 
                StatusCode = model.StatusCode, 
            }; 
        }

        public HistoModifTransfert ToModel()
        {
            return new HistoModifTransfert()
            {
                Id = Id, 
                Hauteur = Hauteur, 
                Temperature = Temperature, 
                IdTransfert = IdTransfert, 
                HauteurProduitBacSourceAvant = HauteurProduitBacSourceAvant, 
                HauteurProduitBacDestinationAvant = HauteurProduitBacDestinationAvant, 
                DateTransfert = DateTransfert, 
                DateCreation = DateCreation, 
                VolumeATBacSourceApres = VolumeATBacSourceApres, 
                VolumeATBacDestinationApres = VolumeATBacDestinationApres, 
                IdAgent = IdAgent, 
                IdBacSource = IdBacSource, 
                IdBacDestination = IdBacDestination, 
                DateModification = DateModification, 
                IdProduit = IdProduit, 
                VolumeATBacSourceAvant = VolumeATBacSourceAvant, 
                VolumeATBacDestinationAvant = VolumeATBacDestinationAvant, 
                DensiteAQuinzeBacSource = DensiteAQuinzeBacSource, 
                DensiteAQuinzeBacDestination = DensiteAQuinzeBacDestination, 
                NsvAvantBacSource = NsvAvantBacSource, 
                NsvAvantBacDestination = NsvAvantBacDestination, 
                NsvApresBacSource = NsvApresBacSource, 
                NsvApresBacDestination = NsvApresBacDestination, 
                HauteurProduitBacSourceApres = HauteurProduitBacSourceApres, 
                HauteurProduitBacDestinationApres = HauteurProduitBacDestinationApres, 
                VolumeCreuxBacSourceAvant = VolumeCreuxBacSourceAvant, 
                VolumeCreuxBacDestinationAvant = VolumeCreuxBacDestinationAvant, 
                VolumeCreuxBacSourceApres = VolumeCreuxBacSourceApres, 
                VolumeCreuxBacDestinationApres = VolumeCreuxBacDestinationApres, 
                IdJaugeSource = IdJaugeSource, 
                IdJaugeDestination = IdJaugeDestination, 
                StatusCode = StatusCode, 
            }; 
        }
    }
}