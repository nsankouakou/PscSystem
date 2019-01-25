using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MenuProfilRepository : RepositoryBase<MenuProfil>, IMenuProfilRepository
    {
        public MenuProfilRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
