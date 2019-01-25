using Api_SNE.Models;
using Contracts;
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
    public class TransfertService
    {
        private IRepositoryWrapper _service { get; set; }
        private ICommonService _commun { get; set; }
        //private ILoggerManager _logger { get; set; }
        public string _strIP { get; set; }
        private readonly ILogger<TransfertService> _logger;

        public TransfertService(ILogger<TransfertService> logger, IRepositoryWrapper repository, ICommonService commun)
        {
            _commun = commun;
            _logger = logger;
            _service = repository;
        }


        public ObjetRetour AddTransfertProduit(TransfertDto transfert)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(transfert.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.Transfert.Create(transfert.ToModel());
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

        public ObjetRetour AddEnvoiProduit(EnvoiProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.EnvoiProduit.Create(value.ToModel());
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

        public ObjetRetour AddReceptionProduit(ReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ReceptionProduit.Create(value.ToModel());
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

        public ObjetRetour UpdateReceptionProduit(ReceptionProduitDto value)
        {
            var retour = new ObjetRetour();
            try
            {
                if (_commun.GetConnexionValide(value.Token, _strIP) == (int)enumEtat.Valide)
                {
                    _service.ReceptionProduit.Update(value.ToModel());
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

    }
}
