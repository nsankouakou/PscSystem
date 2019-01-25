using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using PscClientCore.IService;
using Entities.Models.Dto;
using Api_SNE.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASC.EtatCivilClient.Controllers
{
    public class TypeProduitController : Controller
    {
        private IConfigurationService _service { get; set; }
        protected HttpResponseMessage _response = new HttpResponseMessage();
        protected ObjetRetour Result = new ObjetRetour();

        public TypeProduitController(IConfigurationService service)
        {
            _service = service;            
            
        }

        [HttpPost]
        public async Task<IActionResult> Add(string jsonObject)
        {
            //try
            //{
            //    Response = await Service.AddTypeProduit(jsonObject);
            //    if (Response.IsSuccessStatusCode)
            //    {
            //        Result = await Response.Content.ReadAsAsync<ObjetRetour>();
            //        if (Result.Etat)
            //        {

            //            return Json(new {ok = true, message = "Insertion réalisée avec succès!"});
            //        }
            //        else
            //        {
            //            return Json(new {ok = false, message = Result.MessageErreur});
            //        }
            //    }
            //    else
            //        return
            //            Json(
            //                new
            //                {
            //                    ok = false,
            //                    message = string.Format("{0} : {1}", Response.StatusCode, Response.RequestMessage)
            //                });
            //}
            //catch (Exception ex)
            //{

            //    return Json(new {ok = false, message = ex.Message});
            //}
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Get(string jsonObject)
        {
            try
            {
                _response = await _service.GetTypeProduit(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<TypeProduitDto>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //try
            //{
            //    Response = await Service.GetAllTypeProduit();
            //    if (Response.IsSuccessStatusCode)
            //    {
            //        Result = await Response.Content.ReadAsAsync<ObjetRetour>();
            //        if (Result.Etat)
            //        {
            //            var DecompressResult = JsonConvert.DeserializeObject<List<TypeProduit>>(Result.Contenu.ToString());
            //            return Json(new {ok = true, Data = DecompressResult, message = Result.Message});
            //        }
            //        else
            //        {
            //            return Json(new {ok = false, message = Result.Message});
            //        }
            //    }
            //    else
            //        return
            //            Json(
            //                new
            //                {
            //                    ok = false,
            //                    message = string.Format("{0}: {1}", Response.StatusCode, Response.RequestMessage)
            //                });
            //}
            //catch (Exception ex)
            //{

            //    return Json(new {ok = false, message = ex.Message});
            //}
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetFiltre(string jsonObject)
        {
            try
            {
                _response = await _service.GetFiltreTypeProduit(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {
                        var DecompressResult = JsonConvert.DeserializeObject<List<TypeProduitDto>>(Result.Contenu.ToString());
                        return Json(new { ok = true, Data = DecompressResult, message = Result.Message });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0}: {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Delete(string jsonObject)
        {
            try
            {
                _response = await _service.DeleteTypeProduit(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Suppression réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(string jsonObject)
        {
            try
            {
                _response = await _service.UpdateTypeProduit(jsonObject);
                if (_response.IsSuccessStatusCode)
                {
                    Result = await _response.Content.ReadAsAsync<ObjetRetour>();
                    if (Result.Etat)
                    {

                        return Json(new { ok = true, message = "Mise à réalisée avec succès!" });
                    }
                    else
                    {
                        return Json(new { ok = false, message = Result.Message });
                    }
                }
                else
                    return
                        Json(
                            new
                            {
                                ok = false,
                                message = string.Format("{0} : {1}", _response.StatusCode, _response.RequestMessage)
                            });
            }
            catch (Exception ex)
            {

                return Json(new { ok = false, message = ex.Message });
            }
        }


    }
}
