using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProfilRepository : RepositoryBase<Profil>, IProfilRepository
    {
        public ProfilRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
