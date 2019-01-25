using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CaracteristiqueRepository : RepositoryBase<Caracteristique>, ICaracteristiqueRepository
    {
        public CaracteristiqueRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
