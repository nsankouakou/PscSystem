﻿using Contracts.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class PhotoRepository : RepositoryBase<Photo>, IPhotoRepository
    {
        public PhotoRepository(pscContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
