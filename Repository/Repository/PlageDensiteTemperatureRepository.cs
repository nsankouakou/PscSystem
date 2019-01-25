using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PlageDensiteTemperatureRepository : RepositoryBase<PlageDensiteTemperature>, IPlageDensiteTemperatureRepository
    {
        public PlageDensiteTemperatureRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
