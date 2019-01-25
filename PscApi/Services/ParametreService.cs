using Api_SNE.Models;
using Contracts;
using Entities.Models;
using Entities.Models.Dto;
using Microsoft.Extensions.Logging;
using PscApi.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Entities.Enumerations.Enumeration;

namespace PscApi.Services
{
    public class ParametreService
    {
        private IRepositoryWrapper _service { get; set; }
        private ICommonService _commun { get; set; }
        //private ILoggerManager _logger { get; set; }
        public string _strIP { get; set; }
        private readonly ILogger<ParametreService> _logger;

        public ParametreService(ILogger<ParametreService> logger, IRepositoryWrapper repository, ICommonService commun)
        {
            _commun = commun;
            _logger = logger;
            _service = repository;
        }

        #region Agent

        public async Task<ObjetRetour> GetAllAgent(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Agent.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetAgent(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Agent.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertAgent(AgentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Agent.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajAgent(AgentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Agent.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteAgent(AgentDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Agent.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Bac

        public async Task<ObjetRetour> GetAllBac(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Bac.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetBac(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Bac.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertBac(BacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Bac.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajBac(BacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Bac.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteBac(BacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Bac.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Caracteristique

        public async Task<ObjetRetour> GetAllCaracteristique(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Caracteristique.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetCaracteristique(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Caracteristique.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertCaracteristique(CaracteristiqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Caracteristique.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajCaracteristique(CaracteristiqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Caracteristique.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteCaracteristique(CaracteristiqueDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Caracteristique.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region CaracteristiqueProduit

        public async Task<ObjetRetour> GetAllCaracteristiqueProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.CaracteristiqueProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetCaracteristiqueProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.CaracteristiqueProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertCaracteristiqueProduit(CaracteristiqueProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.CaracteristiqueProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajCaracteristiqueProduit(CaracteristiqueProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.CaracteristiqueProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteCaracteristiqueProduit(CaracteristiqueProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.CaracteristiqueProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region EnvoiProduit

        public async Task<ObjetRetour> GetAllEnvoiProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.EnvoiProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetEnvoiProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.EnvoiProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertEnvoiProduit(EnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.EnvoiProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajEnvoiProduit(EnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.EnvoiProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteEnvoiProduit(EnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.EnvoiProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Fonctionnalite

        public async Task<ObjetRetour> GetAllFonctionnalite(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Fonctionnalite.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetFonctionnalite(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Fonctionnalite.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertFonctionnalite(FonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Fonctionnalite.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajFonctionnalite(FonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Fonctionnalite.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteFonctionnalite(FonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Fonctionnalite.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Grandeur

        public async Task<ObjetRetour> GetAllGrandeur(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Grandeur.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetGrandeur(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Grandeur.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertGrandeur(GrandeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Grandeur.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajGrandeur(GrandeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Grandeur.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteGrandeur(GrandeurDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Grandeur.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region HistoModifEnvoiProduit

        public async Task<ObjetRetour> GetAllHistoModifEnvoiProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifEnvoiProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetHistoModifEnvoiProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifEnvoiProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.HistoModifEnvoiProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifEnvoiProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteHistoModifEnvoiProduit(HistoModifEnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifEnvoiProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region HistoModifJauge

        public async Task<ObjetRetour> GetAllHistoModifJauge(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifJauge.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetHistoModifJauge(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifJauge.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertHistoModifJauge(HistoModifJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.HistoModifJauge.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajHistoModifJauge(HistoModifJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifJauge.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteHistoModifJauge(HistoModifJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifJauge.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region HistoModifReceptionProduit

        public async Task<ObjetRetour> GetAllHistoModifReceptionProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifReceptionProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetHistoModifReceptionProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifReceptionProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertHistoModifReceptionProduit(HistoModifReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.HistoModifReceptionProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajHistoModifReceptionProduit(HistoModifReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifReceptionProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteHistoModifReceptionProduit(HistoModifReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifReceptionProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region HistoModifTransfert

        public async Task<ObjetRetour> GetAllHistoModifTransfert(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifTransfert.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetHistoModifTransfert(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoModifTransfert.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertHistoModifTransfert(HistoModifTransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.HistoModifTransfert.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajHistoModifTransfert(HistoModifTransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifTransfert.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteHistoModifTransfert(HistoModifTransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoModifTransfert.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region HistoriqueJauge

        public async Task<ObjetRetour> GetAllHistoriqueJauge(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoriqueJauge.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetHistoriqueJauge(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.HistoriqueJauge.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertHistoriqueJauge(HistoriqueJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.HistoriqueJauge.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajHistoriqueJauge(HistoriqueJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoriqueJauge.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteHistoriqueJauge(HistoriqueJaugeDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.HistoriqueJauge.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region IntervalleBaremage

        public async Task<ObjetRetour> GetAllIntervalleBaremage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.IntervalleBaremage.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetIntervalleBaremage(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.IntervalleBaremage.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertIntervalleBaremage(IntervalleBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.IntervalleBaremage.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajIntervalleBaremage(IntervalleBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.IntervalleBaremage.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteIntervalleBaremage(IntervalleBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.IntervalleBaremage.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Licence

        public async Task<ObjetRetour> GetAllLicence(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Licence.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetLicence(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Licence.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertLicence(LicenceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Licence.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajLicence(LicenceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Licence.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteLicence(LicenceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Licence.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Menu

        public async Task<ObjetRetour> GetAllMenu(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Menu.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetMenu(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Menu.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertMenu(MenuDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Menu.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajMenu(MenuDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Menu.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteMenu(MenuDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Menu.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region MenuProfilProfil

        public async Task<ObjetRetour> GetAllMenuProfil(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.MenuProfil.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetMenuProfil(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.MenuProfil.FindByConditionAync(a => a.Menuid == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertMenuProfil(MenuProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.MenuProfil.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajMenuProfil(MenuProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.MenuProfil.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteMenuProfil(MenuProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.MenuProfil.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Photo

        public async Task<ObjetRetour> GetAllPhoto(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Photo.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetPhoto(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Photo.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertPhoto(PhotoDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Photo.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajPhoto(PhotoDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Photo.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeletePhoto(PhotoDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Photo.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region PlageDensiteTemperature

        public async Task<ObjetRetour> GetAllPlageDensiteTemperature(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.PlageDensiteTemperature.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetPlageDensiteTemperature(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.PlageDensiteTemperature.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertPlageDensiteTemperature(PlageDensiteTemperatureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.PlageDensiteTemperature.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajPlageDensiteTemperature(PlageDensiteTemperatureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.PlageDensiteTemperature.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeletePlageDensiteTemperature(PlageDensiteTemperatureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.PlageDensiteTemperature.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Produit

        public async Task<ObjetRetour> GetAllProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Produit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Produit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertProduit(ProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Produit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajProduit(ProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Produit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteProduit(ProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Produit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region ProduitBac

        public async Task<ObjetRetour> GetAllProduitBac(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ProduitBac.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetProduitBac(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ProduitBac.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertProduitBac(ProduitBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.ProduitBac.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajProduitBac(ProduitBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ProduitBac.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteProduitBac(ProduitBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ProduitBac.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Profil

        public async Task<ObjetRetour> GetAllProfil(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Profil.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetProfil(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Profil.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertProfil(ProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Profil.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajProfil(ProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Profil.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteProfil(ProfilDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Profil.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region ProfilFonctionnalite

        public async Task<ObjetRetour> GetAllProfilFonctionnalite(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ProfilFonctionnalite.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetProfilFonctionnalite(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ProfilFonctionnalite.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertProfilFonctionnalite(ProfilFonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.ProfilFonctionnalite.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajProfilFonctionnalite(ProfilFonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ProfilFonctionnalite.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteProfilFonctionnalite(ProfilFonctionnaliteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ProfilFonctionnalite.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region ReceptionProduit

        public async Task<ObjetRetour> GetAllReceptionProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ReceptionProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetReceptionProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ReceptionProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertReceptionProduit(ReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.ReceptionProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajReceptionProduit(ReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ReceptionProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteReceptionProduit(ReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ReceptionProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Statut

        public async Task<ObjetRetour> GetAllStatut(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Statut.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetStatut(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Statut.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertStatut(StatutDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Statut.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajStatut(StatutDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Statut.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteStatut(StatutDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Statut.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region TableBaremage

        public async Task<ObjetRetour> GetAllTableBaremage(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TableBaremage.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTableBaremage(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TableBaremage.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTableBaremage(TableBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.TableBaremage.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTableBaremage(TableBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TableBaremage.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTableBaremage(TableBaremageDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TableBaremage.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region TableVolumeDeplace

        public async Task<ObjetRetour> GetAllTableVolumeDeplace(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TableVolumeDeplace.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTableVolumeDeplace(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TableVolumeDeplace.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTableVolumeDeplace(TableVolumeDeplaceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.TableVolumeDeplace.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTableVolumeDeplace(TableVolumeDeplaceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TableVolumeDeplace.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTableVolumeDeplace(TableVolumeDeplaceDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TableVolumeDeplace.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region Transfert

        public async Task<ObjetRetour> GetAllTransfert(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Transfert.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTransfert(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.Transfert.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTransfert(TransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.Transfert.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTransfert(TransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Transfert.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTransfert(TransfertDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Transfert.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region TypeBac

        public async Task<ObjetRetour> GetAllTypeBac(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeBac.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTypeBac(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeBac.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTypeBac(TypeBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.TypeBac.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTypeBac(TypeBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeBac.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTypeBac(TypeBacDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeBac.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region TypeProduit

        public async Task<ObjetRetour> GetAllTypeProduit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeProduit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTypeProduit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeProduit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTypeProduit(TypeProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.TypeProduit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTypeProduit(TypeProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeProduit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTypeProduit(TypeProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeProduit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region TypeToit

        public async Task<ObjetRetour> GetAllTypeToit(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeToit.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetTypeToit(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.TypeToit.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertTypeToit(TypeToitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.TypeToit.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajTypeToit(TypeToitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeToit.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteTypeToit(TypeToitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.TypeToit.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region UniteMesure

        public async Task<ObjetRetour> GetAllUniteMesure(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.UniteMesure.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetUniteMesure(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.UniteMesure.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertUniteMesure(UniteMesureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.UniteMesure.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajUniteMesure(UniteMesureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.UniteMesure.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteUniteMesure(UniteMesureDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.UniteMesure.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

        #region ValeurConversionUnite

        public async Task<ObjetRetour> GetAllValeurConversionUnite(string token = "")
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ValeurConversionUnite.FindAllAsync();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;

        }

        public async Task<ObjetRetour> GetValeurConversionUnite(int id, string token = "")
        {
            var retour = new ObjetRetour();
            try
            {

                if (_commun.GetConnexionValide(token, _strIP) == (int)enumEtat.Valide)
                {
                    retour.Contenu = await _service.ValeurConversionUnite.FindByConditionAync(a => a.Id == id);
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }

            return retour;
        }

        public async Task<ObjetRetour> InsertValeurConversionUnite(ValeurConversionUniteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    await _service.ValeurConversionUnite.CreateAsync(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {

                retour.Etat = false;
                retour.Message = ex.Message;
                _logger.LogError(ex.Message);
            }
            return retour;
        }
        public ObjetRetour MajValeurConversionUnite(ValeurConversionUniteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ValeurConversionUnite.Update(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }


        public ObjetRetour DeleteValeurConversionUnite(ValeurConversionUniteDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ValeurConversionUnite.Delete(value.ToModel());
                    _service.Save();
                    retour.Etat = true;
                     _logger.LogInformation($"SUCCESS");
                }
                else
                {
                    retour.Message = $"Token non valide!";
                    retour.Etat = false;
                     _logger.LogInformation($"Token non valide!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                retour.Etat = false;
                retour.Message = ex.Message;
            }

            return retour;
        }

        #endregion

    }
}
