using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class AgentRepository : RepositoryBase<Agent>, IAgentRepository
    {
        public AgentRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
