using Api_SNE.Models;
using Entities.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PscApi.IServices
{
    public interface IParametreService
    {
        #region Agent
        Task<ObjetRetour> GetAllAgent(string token = "");
        Task<ObjetRetour> GetAgent(int id, string token = "");
        Task<ObjetRetour> InsertAgent(AgentDto value);
        ObjetRetour MajAgent(AgentDto value);
        ObjetRetour DeleteAgent(AgentDto value);
        #endregion

        #region Bac
        Task<ObjetRetour> GetAllBac(string token = "");
        Task<ObjetRetour> GetBac(int id, string token = "");
        Task<ObjetRetour> InsertBac(BacDto value);
        ObjetRetour MajBac(BacDto value);
        ObjetRetour DeleteBac(BacDto value);
        #endregion

        #region Caracteristique
        Task<ObjetRetour> GetAllCaracteristique(string token = "");
        Task<ObjetRetour> GetCaracteristique(int id, string token = "");
        Task<ObjetRetour> InsertCaracteristique(CaracteristiqueDto value);
        ObjetRetour MajCaracteristique(CaracteristiqueDto value);
        ObjetRetour DeleteCaracteristique(CaracteristiqueDto value);
        #endregion

        #region CaracteristiqueProduit
        Task<ObjetRetour> GetAllCaracteristiqueProduit(string token = "");
        Task<ObjetRetour> GetCaracteristiqueProduit(int id, string token = "");
        Task<ObjetRetour> InsertCaracteristiqueProduit(CaracteristiqueProduitDto value);
        ObjetRetour MajCaracteristiqueProduit(CaracteristiqueProduitDto value);
        ObjetRetour DeleteCaracteristiqueProduit(CaracteristiqueProduitDto value);
        #endregion

        #region EnvoiProduit
        Task<ObjetRetour> GetAllEnvoiProduit(string token = "");
        Task<ObjetRetour> GetEnvoiProduit(int id, string token = "");
        Task<ObjetRetour> InsertEnvoiProduit(EnvoiProduitDto value);
        ObjetRetour MajEnvoiProduit(EnvoiProduitDto value);
        ObjetRetour DeleteEnvoiProduit(EnvoiProduitDto value);
        #endregion

        #region Fonctionnalite
        Task<ObjetRetour> GetAllFonctionnalite(string token = "");
        Task<ObjetRetour> GetFonctionnalite(int id, string token = "");
        Task<ObjetRetour> InsertFonctionnalite(FonctionnaliteDto value);
        ObjetRetour MajFonctionnalite(FonctionnaliteDto value);
        ObjetRetour DeleteFonctionnalite(FonctionnaliteDto value);
        #endregion

        #region Grandeur
        Task<ObjetRetour> GetAllGrandeur(string token = "");
        Task<ObjetRetour> GetGrandeur(int id, string token = "");
        Task<ObjetRetour> InsertGrandeur(GrandeurDto value);
        ObjetRetour MajGrandeur(GrandeurDto value);
        ObjetRetour DeleteGrandeur(GrandeurDto value);
        #endregion

        #region HistoModifEnvoiProduit
        Task<ObjetRetour> GetAllHistoModifEnvoiProduit(string token = "");
        Task<ObjetRetour> GetHistoModifEnvoiProduit(int id, string token = "");
        Task<ObjetRetour> InsertHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value);
        ObjetRetour MajHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value);
        ObjetRetour DeleteHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value);
        #endregion

        #region HistoModifJauge
        Task<ObjetRetour> GetAllHistoModifJauge(string token = "");
        Task<ObjetRetour> GetHistoModifJauge(int id, string token = "");
        Task<ObjetRetour> InsertHistoModifJauge(HistoModifJaugeDto value);
        ObjetRetour MajHistoModifJauge(HistoModifJaugeDto value);
        ObjetRetour DeleteHistoModifJauge(HistoModifJaugeDto value);
        #endregion

        #region HistoModifReceptionProduit
        Task<ObjetRetour> GetAllHistoModifReceptionProduit(string token = "");
        Task<ObjetRetour> GetHistoModifReceptionProduit(int id, string token = "");
        Task<ObjetRetour> InsertHistoModifReceptionProduit(HistoModifReceptionProduitDto value);
        ObjetRetour MajHistoModifReceptionProduit(HistoModifReceptionProduitDto value);
        ObjetRetour DeleteHistoModifReceptionProduit(HistoModifReceptionProduitDto value);
        #endregion

        #region HistoModifTransfert
        Task<ObjetRetour> GetAllHistoModifTransfert(string token = "");
        Task<ObjetRetour> GetHistoModifTransfert(int id, string token = "");
        Task<ObjetRetour> InsertHistoModifTransfert(HistoModifTransfertDto value);
        ObjetRetour MajHistoModifTransfert(HistoModifTransfertDto value);
        ObjetRetour DeleteHistoModifTransfert(HistoModifTransfertDto value);
        #endregion

        #region HistoriqueJauge
        Task<ObjetRetour> GetAllHistoriqueJauge(string token = "");
        Task<ObjetRetour> GetHistoriqueJauge(int id, string token = "");
        Task<ObjetRetour> InsertHistoriqueJauge(HistoriqueJaugeDto value);
        ObjetRetour MajHistoriqueJauge(HistoriqueJaugeDto value);
        ObjetRetour DeleteHistoriqueJauge(HistoriqueJaugeDto value);
        #endregion

        #region IntervalleBaremage
        Task<ObjetRetour> GetAllIntervalleBaremage(string token = "");
        Task<ObjetRetour> GetIntervalleBaremage(int id, string token = "");
        Task<ObjetRetour> InsertIntervalleBaremage(IntervalleBaremageDto value);
        ObjetRetour MajIntervalleBaremage(IntervalleBaremageDto value);
        ObjetRetour DeleteIntervalleBaremage(IntervalleBaremageDto value);
        #endregion

        #region Licence
        Task<ObjetRetour> GetAllLicence(string token = "");
        Task<ObjetRetour> GetLicence(int id, string token = "");
        Task<ObjetRetour> InsertLicence(LicenceDto value);
        ObjetRetour MajLicence(LicenceDto value);
        ObjetRetour DeleteLicence(LicenceDto value);
        #endregion

        #region Menu
        Task<ObjetRetour> GetAllMenu(string token = "");
        Task<ObjetRetour> GetMenu(int id, string token = "");
        Task<ObjetRetour> InsertMenu(MenuDto value);
        ObjetRetour MajMenu(MenuDto value);
        ObjetRetour DeleteMenu(MenuDto value);
        #endregion

        #region MenuProfil
        Task<ObjetRetour> GetAllMenuProfil(string token = "");
        Task<ObjetRetour> GetMenuProfil(int id, string token = "");
        Task<ObjetRetour> InsertMenuProfil(MenuProfilDto value);
        ObjetRetour MajMenuProfil(MenuProfilDto value);
        ObjetRetour DeleteMenuProfil(MenuProfilDto value);
        #endregion

        #region Photo
        Task<ObjetRetour> GetAllPhoto(string token = "");
        Task<ObjetRetour> GetPhoto(int id, string token = "");
        Task<ObjetRetour> InsertPhoto(PhotoDto value);
        ObjetRetour MajPhoto(PhotoDto value);
        ObjetRetour DeletePhoto(PhotoDto value);
        #endregion

        #region PlageDensiteTemperature
        Task<ObjetRetour> GetAllPlageDensiteTemperature(string token = "");
        Task<ObjetRetour> GetPlageDensiteTemperature(int id, string token = "");
        Task<ObjetRetour> InsertPlageDensiteTemperature(PlageDensiteTemperatureDto value);
        ObjetRetour MajPlageDensiteTemperature(PlageDensiteTemperatureDto value);
        ObjetRetour DeletePlageDensiteTemperature(PlageDensiteTemperatureDto value);
        #endregion

        #region Produit
        Task<ObjetRetour> GetAllProduit(string token = "");
        Task<ObjetRetour> GetProduit(int id, string token = "");
        Task<ObjetRetour> InsertProduit(ProduitDto value);
        ObjetRetour MajProduit(ProduitDto value);
        ObjetRetour DeleteProduit(ProduitDto value);
        #endregion

        #region ProduitBac
        Task<ObjetRetour> GetAllProduitBac(string token = "");
        Task<ObjetRetour> GetProduitBac(int id, string token = "");
        Task<ObjetRetour> InsertProduitBac(ProduitBacDto value);
        ObjetRetour MajProduitBac(ProduitBacDto value);
        ObjetRetour DeleteProduitBac(ProduitBacDto value);
        #endregion

        #region Profil
        Task<ObjetRetour> GetAllProfil(string token = "");
        Task<ObjetRetour> GetProfil(int id, string token = "");
        Task<ObjetRetour> InsertProfil(ProfilDto value);
        ObjetRetour MajProfil(ProfilDto value);
        ObjetRetour DeleteProfil(ProfilDto value);
        #endregion

        #region ProfilFonctionnalite
        Task<ObjetRetour> GetAllProfilFonctionnalite(string token = "");
        Task<ObjetRetour> GetProfilFonctionnalite(int id, string token = "");
        Task<ObjetRetour> InsertProfilFonctionnalite(ProfilFonctionnaliteDto value);
        ObjetRetour MajProfilFonctionnalite(ProfilFonctionnaliteDto value);
        ObjetRetour DeleteProfilFonctionnalite(ProfilFonctionnaliteDto value);
        #endregion

        #region ReceptionProduit
        Task<ObjetRetour> GetAllReceptionProduit(string token = "");
        Task<ObjetRetour> GetReceptionProduit(int id, string token = "");
        Task<ObjetRetour> InsertReceptionProduit(ReceptionProduitDto value);
        ObjetRetour MajReceptionProduit(ReceptionProduitDto value);
        ObjetRetour DeleteReceptionProduit(ReceptionProduitDto value);
        #endregion

        #region Statut
        Task<ObjetRetour> GetAllStatut(string token = "");
        Task<ObjetRetour> GetStatut(int id, string token = "");
        Task<ObjetRetour> InsertStatut(StatutDto value);
        ObjetRetour MajStatut(StatutDto value);
        ObjetRetour DeleteStatut(StatutDto value);
        #endregion

        #region TableBaremage
        Task<ObjetRetour> GetAllTableBaremage(string token = "");
        Task<ObjetRetour> GetTableBaremage(int id, string token = "");
        Task<ObjetRetour> InsertTableBaremage(TableBaremageDto value);
        ObjetRetour MajTableBaremage(TableBaremageDto value);
        ObjetRetour DeleteTableBaremage(TableBaremageDto value);
        #endregion

        #region TableVolumeDeplace
        Task<ObjetRetour> GetAllTableVolumeDeplace(string token = "");
        Task<ObjetRetour> GetTableVolumeDeplace(int id, string token = "");
        Task<ObjetRetour> InsertTableVolumeDeplace(TableVolumeDeplaceDto value);
        ObjetRetour MajTableVolumeDeplace(TableVolumeDeplaceDto value);
        ObjetRetour DeleteTableVolumeDeplace(TableVolumeDeplaceDto value);
        #endregion

        #region Transfert
        Task<ObjetRetour> GetAllTransfert(string token = "");
        Task<ObjetRetour> GetTransfert(int id, string token = "");
        Task<ObjetRetour> InsertTransfert(TransfertDto value);
        ObjetRetour MajTransfert(TransfertDto value);
        ObjetRetour DeleteTransfert(TransfertDto value);
        #endregion

        #region TypeBac
        Task<ObjetRetour> GetAllTypeBac(string token = "");
        Task<ObjetRetour> GetTypeBac(int id, string token = "");
        Task<ObjetRetour> InsertTypeBac(TypeBacDto value);
        ObjetRetour MajTypeBac(TypeBacDto value);
        ObjetRetour DeleteTypeBac(TypeBacDto value);
        #endregion

        #region TypeProduit
        Task<ObjetRetour> GetAllTypeProduit(string token = "");
        Task<ObjetRetour> GetTypeProduit(int id, string token = "");
        Task<ObjetRetour> InsertTypeProduit(TypeProduitDto value);
        ObjetRetour MajTypeProduit(TypeProduitDto value);
        ObjetRetour DeleteTypeProduit(TypeProduitDto value);
        #endregion

        #region TypeToit
        Task<ObjetRetour> GetAllTypeToit(string token = "");
        Task<ObjetRetour> GetTypeToit(int id, string token = "");
        Task<ObjetRetour> InsertTypeToit(TypeToitDto value);
        ObjetRetour MajTypeToit(TypeToitDto value);
        ObjetRetour DeleteTypeToit(TypeToitDto value);
        #endregion

        #region UniteMesure
        Task<ObjetRetour> GetAllUniteMesure(string token = "");
        Task<ObjetRetour> GetUniteMesure(int id, string token = "");
        Task<ObjetRetour> InsertUniteMesure(UniteMesureDto value);
        ObjetRetour MajUniteMesure(UniteMesureDto value);
        ObjetRetour DeleteUniteMesure(UniteMesureDto value);
        #endregion

        #region ValeurConversionUnite
        Task<ObjetRetour> GetAllValeurConversionUnite(string token = "");
        Task<ObjetRetour> GetValeurConversionUnite(int id, string token = "");
        Task<ObjetRetour> InsertValeurConversionUnite(ValeurConversionUniteDto value);
        ObjetRetour MajValeurConversionUnite(ValeurConversionUniteDto value);
        ObjetRetour DeleteValeurConversionUnite(ValeurConversionUniteDto value);
        #endregion
    }
}
