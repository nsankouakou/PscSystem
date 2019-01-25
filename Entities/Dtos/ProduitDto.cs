using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Models.Dto
{
    public class ProduitDto
    {
        public int Id { get; set; }

        public string Designation { get; set; }

        public int? IdTypeProduit { get; set; }

        public DateTime? DateCreation { get; set; }

        public double? DentiteAQuizeMini { get; set; }

        public double? DensiteAQuizeMaxi { get; set; }

        public short? EstPretroleBrut { get; set; }

        public int? StatutCode { get; set; }

        public TypeProduitDto IdTypeProduitNavigation { get; set; }

        public ICollection<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }

        public ICollection<EnvoiProduit> EnvoiProduit { get; set; }

        public ICollection<HistoriqueJauge> HistoriqueJauge { get; set; }

        public ICollection<ProduitBac> ProduitBac { get; set; }

        public ICollection<ReceptionProduit> ReceptionProduit { get; set; }

        public ICollection<Transfert> Transfert { get; set; }

        public string Token { get; set; }

        public static ProduitDto FromModel(Produit model)
        {
            return new ProduitDto()
            {
                Id = model.Id, 
                Designation = model.Designation, 
                IdTypeProduit = model.IdTypeProduit, 
                DateCreation = model.DateCreation, 
                DentiteAQuizeMini = model.DentiteAQuizeMini, 
                DensiteAQuizeMaxi = model.DensiteAQuizeMaxi, 
                EstPretroleBrut = model.EstPretroleBrut, 
                StatutCode = model.StatutCode, 
                IdTypeProduitNavigation = TypeProduitDto.FromModel(model.IdTypeProduitNavigation), 
                CaracteristiqueProduit = model.CaracteristiqueProduit, 
                EnvoiProduit = model.EnvoiProduit, 
                HistoriqueJauge = model.HistoriqueJauge, 
                ProduitBac = model.ProduitBac, 
                ReceptionProduit = model.ReceptionProduit, 
                Transfert = model.Transfert, 
            }; 
        }

        public Produit ToModel()
        {
            return new Produit()
            {
                Id = Id, 
                Designation = Designation, 
                IdTypeProduit = IdTypeProduit, 
                DateCreation = DateCreation, 
                DentiteAQuizeMini = DentiteAQuizeMini, 
                DensiteAQuizeMaxi = DensiteAQuizeMaxi, 
                EstPretroleBrut = EstPretroleBrut, 
                StatutCode = StatutCode, 
                IdTypeProduitNavigation = IdTypeProduitNavigation.ToModel(), 
                CaracteristiqueProduit = CaracteristiqueProduit, 
                EnvoiProduit = EnvoiProduit, 
                HistoriqueJauge = HistoriqueJauge, 
                ProduitBac = ProduitBac, 
                ReceptionProduit = ReceptionProduit, 
                Transfert = Transfert, 
            }; 
        }
    }
}