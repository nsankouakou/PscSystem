using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HistoModifTransfertRepository : RepositoryBase<HistoModifTransfert>, IHistoModifTransfertRepository
    {
        public HistoModifTransfertRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
