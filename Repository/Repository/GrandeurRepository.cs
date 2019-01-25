using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class GrandeurRepository : RepositoryBase<Grandeur>, IGrandeurRepository
    {
        public GrandeurRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
