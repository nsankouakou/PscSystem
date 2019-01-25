using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProduitRepository : RepositoryBase<Produit>, IProduitRepository
    {
        public ProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
