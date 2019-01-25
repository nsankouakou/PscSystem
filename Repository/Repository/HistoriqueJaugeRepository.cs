using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HistoriqueJaugeRepository : RepositoryBase<HistoriqueJauge>, IHistoriqueJaugeRepository
    {
        public HistoriqueJaugeRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
