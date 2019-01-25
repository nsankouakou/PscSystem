using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TypeBacRepository : RepositoryBase<TypeBac>, ITypeBacRepository
    {
        public TypeBacRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
