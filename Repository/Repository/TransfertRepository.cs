using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TransfertRepository : RepositoryBase<Transfert>, ITransfertRepository
    {
        public TransfertRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
