using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class StatutRepository : RepositoryBase<Statut>, IStatutRepository
    {
        public StatutRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
