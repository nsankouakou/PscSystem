using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ProfilFonctionnaliteRepository : RepositoryBase<ProfilFonctionnalite>, IProfilFonctionnaliteRepository
    {
        public ProfilFonctionnaliteRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
