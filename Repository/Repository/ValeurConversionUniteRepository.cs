using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ValeurConversionUniteRepository : RepositoryBase<ValeurConversionUnite>, IValeurConversionUniteRepository
    {
        public ValeurConversionUniteRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
