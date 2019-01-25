using System.Net.Http;
using System.Threading.Tasks;

namespace PscClientCore.IService
{
    public interface IConfigurationService
    {

        #region UniteMesure
        Task<HttpResponseMessage> AddUniteMesure(string jsonObject);
        Task<HttpResponseMessage> UpdateUniteMesure(string jsonObject);
        Task<HttpResponseMessage> GetUniteMesure(string jsonObject);
        Task<HttpResponseMessage> GetFiltreUniteMesure(string jsonObject);
        Task<HttpResponseMessage> GetAllUniteMesure();
        Task<HttpResponseMessage> DeleteUniteMesure(string jsonObject);
        #endregion

        #region TypeToit
        Task<HttpResponseMessage> AddTypeToit(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeToit(string jsonObject);
        Task<HttpResponseMessage> GetTypeToit(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeToit(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeToit();
        Task<HttpResponseMessage> DeleteTypeToit(string jsonObject);
        #endregion

        #region TypeProduit
        Task<HttpResponseMessage> AddTypeProduit(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeProduit(string jsonObject);
        Task<HttpResponseMessage> GetTypeProduit(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeProduit(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeProduit();
        Task<HttpResponseMessage> DeleteTypeProduit(string jsonObject);
        #endregion

        #region Produit
        Task<HttpResponseMessage> AddProduit(string jsonObject);
        Task<HttpResponseMessage> UpdateProduit(string jsonObject);
        Task<HttpResponseMessage> GetProduit(string jsonObject);
        Task<HttpResponseMessage> GetFiltreProduit(string jsonObject);
        Task<HttpResponseMessage> GetAllProduit();
        Task<HttpResponseMessage> DeleteProduit(string jsonObject);
        #endregion

        #region TypeBac
        Task<HttpResponseMessage> AddTypeBac(string jsonObject);
        Task<HttpResponseMessage> UpdateTypeBac(string jsonObject);
        Task<HttpResponseMessage> GetTypeBac(string jsonObject);
        Task<HttpResponseMessage> GetFiltreTypeBac(string jsonObject);
        Task<HttpResponseMessage> GetAllTypeBac();
        Task<HttpResponseMessage> DeleteTypeBac(string jsonObject);
        #endregion

        #region ValeurConversionUnite
        Task<HttpResponseMessage> AddValeurConversionUnite(string jsonObject);
        Task<HttpResponseMessage> UpdateValeurConversionUnite(string jsonObject);
        Task<HttpResponseMessage> GetValeurConversionUnite(string jsonObject);
        Task<HttpResponseMessage> GetFiltreValeurConversionUnite(string jsonObject);
        Task<HttpResponseMessage> GetAllValeurConversionUnite();
        Task<HttpResponseMessage> DeleteValeurConversionUnite(string jsonObject);
        #endregion

        #region Caracteristique
        Task<HttpResponseMessage> AddCaracteristique(string jsonObject);
        Task<HttpResponseMessage> UpdateCaracteristique(string jsonObject);
        Task<HttpResponseMessage> GetCaracteristique(string jsonObject);
        Task<HttpResponseMessage> GetFiltreCaracteristique(string jsonObject);
        Task<HttpResponseMessage> GetAllCaracteristique();
        Task<HttpResponseMessage> DeleteCaracteristique(string jsonObject);
        #endregion

    }
}
