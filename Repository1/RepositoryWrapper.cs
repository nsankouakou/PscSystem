using Contracts;
using Contracts.Interfaces;
//using Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper //: IRepositoryWrapper
    {
        //private readonly CARPABDContext _repoContext;
        IDbContextTransaction _transaction = null;

        public RepositoryWrapper(/*CARPABDContext repositoryContext*/)
        {
            //_repoContext = repositoryContext;
            //_transaction = _repoContext.Database.BeginTransaction();
        }


        
        //private bool _disposed = false;


        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!this._disposed)
        //    {
                
        //        if (disposing)
        //        {
        //            _transaction.Dispose();
        //            _repoContext.Dispose();
        //        }
        //    }
        //    this._disposed = true;
        //}
        //public string Save()
        //{
        //    string strValidatinoError = string.Empty;
        //    try
        //    {

        //        _repoContext.SaveChanges();
        //        _transaction.Commit();
        //    }

        //    finally
        //    {
        //        //
        //    }

        //    return strValidatinoError;
        //}




        

        //private IAspnetApplicationsRepository _AspnetApplications;

        //public IAspnetApplicationsRepository AspnetApplications
        //{
        //    get
        //    {
        //        if (_AspnetApplications == null)
        //        {
        //            _AspnetApplications = new AspnetApplicationsRepository(_repoContext);
        //        }

        //        return _AspnetApplications;
        //    }
        //}

        //private IAspnetPathsRepository _AspnetPaths;

        //public IAspnetPathsRepository AspnetPaths
        //{
        //    get
        //    {
        //        if (_AspnetPaths == null)
        //        {
        //            _AspnetPaths = new AspnetPathsRepository(_repoContext);
        //        }

        //        return _AspnetPaths;
        //    }
        //}

        //private IAspnetProfileRepository _AspnetProfile;

        //public IAspnetProfileRepository AspnetProfile
        //{
        //    get
        //    {
        //        if (_AspnetProfile == null)
        //        {
        //            _AspnetProfile = new AspnetProfileRepository(_repoContext);
        //        }

        //        return _AspnetProfile;
        //    }
        //}

        //private IAspnetRolesRepository _AspnetRoles;

        //public IAspnetRolesRepository AspnetRoles
        //{
        //    get
        //    {
        //        if (_AspnetRoles == null)
        //        {
        //            _AspnetRoles = new AspnetRolesRepository(_repoContext);
        //        }

        //        return _AspnetRoles;
        //    }
        //}

        //private IAspnetSchemaVersionsRepository _AspnetSchemaVersions;

        //public IAspnetSchemaVersionsRepository AspnetSchemaVersions
        //{
        //    get
        //    {
        //        if (_AspnetSchemaVersions == null)
        //        {
        //            _AspnetSchemaVersions = new AspnetSchemaVersionsRepository(_repoContext);
        //        }

        //        return _AspnetSchemaVersions;
        //    }
        //}

        

        //private ISupportMouvementRepository _SupportMouvement;

        //public ISupportMouvementRepository SupportMouvement
        //{
        //    get
        //    {
        //        if (_SupportMouvement == null)
        //        {
        //            _SupportMouvement = new SupportMouvementRepository(_repoContext);
        //        }

        //        return _SupportMouvement;
        //    }
        //}

    }
}
