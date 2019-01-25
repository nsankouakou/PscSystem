using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TypeProduitRepository : RepositoryBase<TypeProduit>, ITypeProduitRepository
    {
        public TypeProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
