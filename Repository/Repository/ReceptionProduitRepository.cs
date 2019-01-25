using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ReceptionProduitRepository : RepositoryBase<ReceptionProduit>, IReceptionProduitRepository
    {
        public ReceptionProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
