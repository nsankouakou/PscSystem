using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class FonctionnaliteRepository : RepositoryBase<Fonctionnalite>, IFonctionnaliteRepository
    {
        public FonctionnaliteRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
