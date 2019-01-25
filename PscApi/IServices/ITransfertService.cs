using Api_SNE.Models;
using Entities.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PscApi.IServices
{
    public interface ITransfertService
    {
        ObjetRetour AddTransfertProduit(TransfertDto transfert);
    }
}
