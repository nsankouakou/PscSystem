using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HistoModifEnvoiProduitRepository : RepositoryBase<HistoModifEnvoiProduit>, IHistoModifEnvoiProduitRepository
    {
        public HistoModifEnvoiProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
