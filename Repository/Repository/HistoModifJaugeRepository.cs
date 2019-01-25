using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HistoModifJaugeRepository : RepositoryBase<HistoModifJauge>, IHistoModifJaugeRepository
    {
        public HistoModifJaugeRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
