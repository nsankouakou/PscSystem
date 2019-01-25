using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TypeToitRepository : RepositoryBase<TypeToit>, ITypeToitRepository
    {
        public TypeToitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
