using Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        string Save();
        void Dispose();
        

        IAgentRepository Agent { get; }

        IBacRepository Bac { get; }

        ICaracteristiqueRepository Caracteristique { get; }

        ICaracteristiqueProduitRepository CaracteristiqueProduit { get; }

        IEnvoiProduitRepository EnvoiProduit { get; }

        IFonctionnaliteRepository Fonctionnalite { get; }

        IGrandeurRepository Grandeur { get; }

        IHistoModifEnvoiProduitRepository HistoModifEnvoiProduit { get; }

        IHistoModifJaugeRepository HistoModifJauge { get; }

        IHistoModifReceptionProduitRepository HistoModifReceptionProduit { get; }

        IHistoModifTransfertRepository HistoModifTransfert { get; }

        IHistoriqueJaugeRepository HistoriqueJauge { get; }

        IIntervalleBaremageRepository IntervalleBaremage { get; }

        ILicenceRepository Licence { get; }

        IMenuRepository Menu { get; }

        IMenuProfilRepository MenuProfil { get; }

        IPhotoRepository Photo { get; }

        IPlageDensiteTemperatureRepository PlageDensiteTemperature { get; }

        IProduitRepository Produit { get; }

        IProfilRepository Profil { get; }

        IProduitBacRepository ProduitBac { get; }

        IProfilFonctionnaliteRepository ProfilFonctionnalite { get; }

        IReceptionProduitRepository ReceptionProduit { get; }

        IStatutRepository Statut { get; }

        ITableBaremageRepository TableBaremage { get; }

        ITableVolumeDeplaceRepository TableVolumeDeplace { get; }

        ITransfertRepository Transfert { get; }

        ITypeBacRepository TypeBac { get; }

        ITypeProduitRepository TypeProduit { get; }

        ITypeToitRepository TypeToit { get; }

        IUniteMesureRepository UniteMesure { get; }

        IValeurConversionUniteRepository ValeurConversionUnite { get; }


    }
}
