using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HistoModifReceptionProduitRepository : RepositoryBase<HistoModifReceptionProduit>, IHistoModifReceptionProduitRepository
    {
        public HistoModifReceptionProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
