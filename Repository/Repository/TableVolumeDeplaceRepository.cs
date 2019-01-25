using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class TableVolumeDeplaceRepository : RepositoryBase<TableVolumeDeplace>, ITableVolumeDeplaceRepository
    {
        public TableVolumeDeplaceRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
