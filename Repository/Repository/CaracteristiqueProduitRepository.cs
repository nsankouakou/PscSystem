using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CaracteristiqueProduitRepository : RepositoryBase<CaracteristiqueProduit>, ICaracteristiqueProduitRepository
    {
        public CaracteristiqueProduitRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
