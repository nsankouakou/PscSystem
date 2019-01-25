using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using PscClientCore.IService;
using Entities.Models.Dto;

namespace PscClientCore.Service
{
    public class ConfigurationService : IConfigurationService
    {
        public ConfigurationService()
        {


        }

        #region Produit
        
        public async Task<HttpResponseMessage> AddProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<ProduitDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<ProduitDto>("api/Configuration/Acte/add", val);
        }        
        public async Task<HttpResponseMessage> DeleteProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }       
        public async Task<HttpResponseMessage> GetAllProduit()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }        
        public async Task<HttpResponseMessage> GetFiltreProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
       
        public async Task<HttpResponseMessage> UpdateProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<ProduitDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<ProduitDto>("api/Configuration/Acte/add", val);
        }
        #endregion

        #region TypeBac
        
        public async Task<HttpResponseMessage> AddTypeBac(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeBacDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeBacDto>("api/Configuration/Acte/add", val);
        }        
        public async Task<HttpResponseMessage> DeleteTypeBac(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }       
        public async Task<HttpResponseMessage> GetAllTypeBac()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }
        public async Task<HttpResponseMessage> GetFiltreTypeBac(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }        
        public async Task<HttpResponseMessage> GetTypeBac(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }        
        public async Task<HttpResponseMessage> UpdateTypeBac(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeBacDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeBacDto>("api/Configuration/Acte/add", val);
        }
        #endregion

        #region TypeProduit
       
        public async Task<HttpResponseMessage> DeleteTypeProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("/api/Parametres/DeleteTypeProduit", val);
        }
        
        public async Task<HttpResponseMessage> GetAllTypeProduit()
        {
            return await Utility.ClientBaseApi().GetAsync("/api/Parametres/GetALLTypeProduit");
        }
        public async Task<HttpResponseMessage> UpdateTypeProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeProduitDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeProduitDto>("/api/Parametres/MajTypeProduit", val);
        }
       
        public async Task<HttpResponseMessage> GetTypeProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "/api/Parametres/GeTypeProduitUnique?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreTypeProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
       
        public async Task<HttpResponseMessage> AddTypeProduit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeProduitDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeProduitDto>("/api/Parametres/InserTypeProduit", val);
        }

        #endregion

        #region TypeToit
        public async Task<HttpResponseMessage> AddTypeToit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeToitDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeToitDto>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetAllTypeToit()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }
        public async Task<HttpResponseMessage> DeleteTypeToit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> UpdateTypeToit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<TypeToitDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<TypeToitDto>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetTypeToit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreTypeToit(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        #endregion

        #region UniteMesure
        public async Task<HttpResponseMessage> AddUniteMesure(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<UniteMesureDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<UniteMesureDto>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetAllUniteMesure()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }
        public async Task<HttpResponseMessage> DeleteUniteMesure(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetUniteMesure(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetFiltreUniteMesure(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> UpdateUniteMesure(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<UniteMesureDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<UniteMesureDto>("api/Configuration/Acte/add", val);
        }

        #endregion

        #region ValeurConversionUnite
        public async Task<HttpResponseMessage> AddValeurConversionUnite(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<ValeurConversionUniteDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<ValeurConversionUniteDto>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> DeleteValeurConversionUnite(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetAllValeurConversionUnite()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }
        public async Task<HttpResponseMessage> GetFiltreValeurConversionUnite(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetValeurConversionUnite(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> UpdateValeurConversionUnite(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<ValeurConversionUniteDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<ValeurConversionUniteDto>("api/Configuration/Acte/add", val);
        }
        #endregion

        #region Caracteristique
        public async Task<HttpResponseMessage> AddCaracteristique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<CaracteristiqueDto>(ic.ToString());

            return await Utility.ClientBaseApi().PostAsJsonAsync<CaracteristiqueDto>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> DeleteCaracteristique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            return await Utility.ClientBaseApi().PostAsJsonAsync<int>("api/Configuration/Acte/add", val);
        }
        public async Task<HttpResponseMessage> GetAllCaracteristique()
        {
            return await Utility.ClientBaseApi().GetAsync("api/Configuration/Acte/Edit");
        }
        public async Task<HttpResponseMessage> GetFiltreCaracteristique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (string)ic["strRech"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> GetCaracteristique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = (int)ic["id"];
            string url = "api/Configuration/Acte/Get?id=" + val;
            return await Utility.ClientBaseApi().GetAsync(url);
        }
        public async Task<HttpResponseMessage> UpdateCaracteristique(string jsonObject)
        {
            var ic = JObject.Parse(jsonObject);
            var val = JsonConvert.DeserializeObject<CaracteristiqueDto>(ic.ToString());
            return await Utility.ClientBaseApi().PostAsJsonAsync<CaracteristiqueDto>("api/Configuration/Acte/add", val);
        }

        #endregion
        
    }
}
