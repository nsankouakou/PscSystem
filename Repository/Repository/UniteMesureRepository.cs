using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class UniteMesureRepository : RepositoryBase<UniteMesure>, IUniteMesureRepository
    {
        public UniteMesureRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
