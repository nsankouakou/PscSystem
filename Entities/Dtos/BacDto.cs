using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class BacDto
    {
        public int Id { get; set; }

        public string Repere { get; set; }

        public int? IdTypeBac { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public int? IdTypeToit { get; set; }

        public DateTime? DateCreation { get; set; }

        public double? Diametre { get; set; }

        public double? VolumeTotal { get; set; }

        public DateTime? DateDerogation { get; set; }

        public int? IdStatut { get; set; }

        public double? HauteurMiniExplotation { get; set; }

        public double? VolumeNonPompable { get; set; }

        public double? TonnageBrut { get; set; }

        public double? TonnageNet { get; set; }

        public double? HauteurTotalReference { get; set; }

        public double? VolumeTheorique { get; set; }

        public double? VolumeReel { get; set; }

        public double? MasseDuToit { get; set; }

        public double? HauteurMiniZoneIncertitude { get; set; }

        public double? HauteurMaxiZoneIncertitude { get; set; }

        public double? HauteurMaximalJauge { get; set; }

        public int? StatusCode { get; set; }

        public StatutDto IdStatutNavigation { get; set; }

        public TypeBacDto IdTypeBacNavigation { get; set; }

        public TypeToitDto IdTypeToitNavigation { get; set; }

        public ICollection<EnvoiProduit> EnvoiProduit { get; set; }

        public ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }

        public ICollection<IntervalleBaremage> IntervalleBaremage { get; set; }

        public ICollection<ProduitBac> ProduitBac { get; set; }

        public ICollection<ReceptionProduit> ReceptionProduit { get; set; }

        public ICollection<TableVolumeDeplace> TableVolumeDeplace { get; set; }

        public ICollection<Transfert> TransfertIdBacDestinationNavigation { get; set; }

        public ICollection<Transfert> TransfertIdBacSourceNavigation { get; set; }

        public string Token { get; set; }

        public static BacDto FromModel(Bac model)
        {
            return new BacDto()
            {
                Id = model.Id, 
                Repere = model.Repere, 
                IdTypeBac = model.IdTypeBac, 
                DateDebut = model.DateDebut, 
                DateFin = model.DateFin, 
                IdTypeToit = model.IdTypeToit, 
                DateCreation = model.DateCreation, 
                Diametre = model.Diametre, 
                VolumeTotal = model.VolumeTotal, 
                DateDerogation = model.DateDerogation, 
                IdStatut = model.IdStatut, 
                HauteurMiniExplotation = model.HauteurMiniExplotation, 
                VolumeNonPompable = model.VolumeNonPompable, 
                TonnageBrut = model.TonnageBrut, 
                TonnageNet = model.TonnageNet, 
                HauteurTotalReference = model.HauteurTotalReference, 
                VolumeTheorique = model.VolumeTheorique, 
                VolumeReel = model.VolumeReel, 
                MasseDuToit = model.MasseDuToit, 
                HauteurMiniZoneIncertitude = model.HauteurMiniZoneIncertitude, 
                HauteurMaxiZoneIncertitude = model.HauteurMaxiZoneIncertitude, 
                HauteurMaximalJauge = model.HauteurMaximalJauge, 
                StatusCode = model.StatusCode, 
                IdStatutNavigation = StatutDto.FromModel(model.IdStatutNavigation), 
                IdTypeBacNavigation = TypeBacDto.FromModel(model.IdTypeBacNavigation), 
                IdTypeToitNavigation = TypeToitDto.FromModel(model.IdTypeToitNavigation), 
                EnvoiProduit = model.EnvoiProduit, 
                HistoriqueJauge = model.HistoriqueJauge, 
                IntervalleBaremage = model.IntervalleBaremage, 
                ProduitBac = model.ProduitBac, 
                ReceptionProduit = model.ReceptionProduit, 
                TableVolumeDeplace = model.TableVolumeDeplace, 
                TransfertIdBacDestinationNavigation = model.TransfertIdBacDestinationNavigation, 
                TransfertIdBacSourceNavigation = model.TransfertIdBacSourceNavigation, 
            }; 
        }

        public Bac ToModel()
        {
            return new Bac()
            {
                Id = Id, 
                Repere = Repere, 
                IdTypeBac = IdTypeBac, 
                DateDebut = DateDebut, 
                DateFin = DateFin, 
                IdTypeToit = IdTypeToit, 
                DateCreation = DateCreation, 
                Diametre = Diametre, 
                VolumeTotal = VolumeTotal, 
                DateDerogation = DateDerogation, 
                IdStatut = IdStatut, 
                HauteurMiniExplotation = HauteurMiniExplotation, 
                VolumeNonPompable = VolumeNonPompable, 
                TonnageBrut = TonnageBrut, 
                TonnageNet = TonnageNet, 
                HauteurTotalReference = HauteurTotalReference, 
                VolumeTheorique = VolumeTheorique, 
                VolumeReel = VolumeReel, 
                MasseDuToit = MasseDuToit, 
                HauteurMiniZoneIncertitude = HauteurMiniZoneIncertitude, 
                HauteurMaxiZoneIncertitude = HauteurMaxiZoneIncertitude, 
                HauteurMaximalJauge = HauteurMaximalJauge, 
                StatusCode = StatusCode, 
                IdStatutNavigation = IdStatutNavigation.ToModel(), 
                IdTypeBacNavigation = IdTypeBacNavigation.ToModel(), 
                IdTypeToitNavigation = IdTypeToitNavigation.ToModel(), 
                EnvoiProduit = EnvoiProduit, 
                HistoriqueJauge = HistoriqueJauge, 
                IntervalleBaremage = IntervalleBaremage, 
                ProduitBac = ProduitBac, 
                ReceptionProduit = ReceptionProduit, 
                TableVolumeDeplace = TableVolumeDeplace, 
                TransfertIdBacDestinationNavigation = TransfertIdBacDestinationNavigation, 
                TransfertIdBacSourceNavigation = TransfertIdBacSourceNavigation, 
            }; 
        }
    }
}