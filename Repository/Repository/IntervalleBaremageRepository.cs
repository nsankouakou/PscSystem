using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class IntervalleBaremageRepository : RepositoryBase<IntervalleBaremage>, IIntervalleBaremageRepository
    {
        public IntervalleBaremageRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
