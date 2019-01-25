using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TableBaremageRepository : RepositoryBase<TableBaremage>, ITableBaremageRepository
    {
        public TableBaremageRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
