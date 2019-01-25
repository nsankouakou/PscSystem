using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class LicenceRepository : RepositoryBase<Licence>, ILicenceRepository
    {
        public LicenceRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
