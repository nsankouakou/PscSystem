using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class BacRepository : RepositoryBase<Bac>, IBacRepository
    {
        public BacRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
