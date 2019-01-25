using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProduitBacRepository : RepositoryBase<ProduitBac>, IProduitBacRepository
    {
        public ProduitBacRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
