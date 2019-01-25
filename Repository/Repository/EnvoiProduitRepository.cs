using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class EnvoiProduitRepository : RepositoryBase<EnvoiProduit>, IEnvoiProduitRepository
    {
        public EnvoiProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
