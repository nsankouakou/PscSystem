using Contracts;
using Contracts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly pscContext _repoContext;
        IDbContextTransaction _transaction = null;

        public RepositoryWrapper(pscContext repositoryContext)
        {
            _repoContext = repositoryContext;
            _transaction = _repoContext.Database.BeginTransaction();
        }


        
        private bool _disposed = false;


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                
                if (disposing)
                {
                    _transaction.Dispose();
                    _repoContext.Dispose();
                }
            }
            this._disposed = true;
        }

        public string Save()
        {
            
                _repoContext.SaveChanges();
                _transaction.Commit();

            return "";
        }
       

       

        private IAgentRepository _Agent;

        public IAgentRepository Agent
        {
            get
            {
                if (_Agent == null)
                {
                     _Agent = new AgentRepository(_repoContext);
                }

                return _Agent;
            }
        }

        private IBacRepository _Bac;

        public IBacRepository Bac
        {
            get
            {
                if (_Bac == null)
                {
                    _Bac = new BacRepository(_repoContext);
                }

                return _Bac;
            }
        }

        private ICaracteristiqueRepository _Caracteristique;

        public ICaracteristiqueRepository Caracteristique
        {
            get
            {
                if (_Caracteristique == null)
                {
                    _Caracteristique = new CaracteristiqueRepository(_repoContext);
                }

                return _Caracteristique;
            }
        }


        private ICaracteristiqueProduitRepository _CaracteristiqueProduit;

        public ICaracteristiqueProduitRepository CaracteristiqueProduit
        {
            get
            {
                if (_CaracteristiqueProduit == null)
                {
                    _CaracteristiqueProduit = new CaracteristiqueProduitRepository(_repoContext);
                }

                return _CaracteristiqueProduit;
            }
        }

        private IEnvoiProduitRepository _EnvoiProduit;

        public IEnvoiProduitRepository EnvoiProduit
        {
            get
            {
                if (_EnvoiProduit == null)
                {
                    _EnvoiProduit = new EnvoiProduitRepository(_repoContext);
                }

                return _EnvoiProduit;
            }
        }

        private IFonctionnaliteRepository _Fonctionnalite;

        public IFonctionnaliteRepository Fonctionnalite
        {
            get
            {
                if (_Fonctionnalite == null)
                {
                    _Fonctionnalite = new FonctionnaliteRepository(_repoContext);
                }

                return _Fonctionnalite;
            }
        }

        private IGrandeurRepository _Grandeur;

        public IGrandeurRepository Grandeur
        {
            get
            {
                if (_Grandeur == null)
                {
                    _Grandeur = new GrandeurRepository(_repoContext);
                }

                return _Grandeur;
            }
        }

        private IHistoModifEnvoiProduitRepository _HistoModifEnvoiProduit;

        public IHistoModifEnvoiProduitRepository HistoModifEnvoiProduit
        {
            get
            {
                if (_HistoModifEnvoiProduit == null)
                {
                    _HistoModifEnvoiProduit = new HistoModifEnvoiProduitRepository(_repoContext);
                }

                return _HistoModifEnvoiProduit;
            }
        }

        private IHistoModifJaugeRepository _HistoModifJauge;

        public IHistoModifJaugeRepository HistoModifJauge
        {
            get
            {
                if (_HistoModifJauge == null)
                {
                    _HistoModifJauge = new HistoModifJaugeRepository(_repoContext);
                }

                return _HistoModifJauge;
            }
        }

        private IHistoModifReceptionProduitRepository _HistoModifReceptionProduit;

        public IHistoModifReceptionProduitRepository HistoModifReceptionProduit
        {
            get
            {
                if (_HistoModifReceptionProduit == null)
                {
                    _HistoModifReceptionProduit = new HistoModifReceptionProduitRepository(_repoContext);
                }

                return _HistoModifReceptionProduit;
            }
        }

        private IHistoModifTransfertRepository _HistoModifTransfert;

        public IHistoModifTransfertRepository HistoModifTransfert
        {
            get
            {
                if (_HistoModifTransfert == null)
                {
                    _HistoModifTransfert = new HistoModifTransfertRepository(_repoContext);
                }

                return _HistoModifTransfert;
            }
        }

        private IHistoriqueJaugeRepository _HistoriqueJauge;

        public IHistoriqueJaugeRepository HistoriqueJauge
        {
            get
            {
                if (_HistoriqueJauge == null)
                {
                    _HistoriqueJauge = new HistoriqueJaugeRepository(_repoContext);
                }

                return _HistoriqueJauge;
            }
        }



        private IIntervalleBaremageRepository _IntervalleBaremage;

        public IIntervalleBaremageRepository IntervalleBaremage
        {
            get
            {
                if (_IntervalleBaremage == null)
                {
                    _IntervalleBaremage = new IntervalleBaremageRepository(_repoContext);
                }

                return _IntervalleBaremage;
            }
        }

        private ILicenceRepository _Licence;

        public ILicenceRepository Licence
        {
            get
            {
                if (_Licence == null)
                {
                    _Licence = new LicenceRepository(_repoContext);
                }

                return _Licence;
            }
        }
            private IMenuRepository _Menu;

        public IMenuRepository Menu
        {
            get
            {
                if (_Menu == null)
                {
                    _Menu = new MenuRepository(_repoContext);
                }

                return _Menu;
            }
        }

        private IMenuProfilRepository _MenuProfil;

        public IMenuProfilRepository MenuProfil
        {
            get
            {
                if (_MenuProfil == null)
                {
                    _MenuProfil = new MenuProfilRepository(_repoContext);
                }

                return _MenuProfil;
            }
        }

        private IPhotoRepository _Photo;

        public IPhotoRepository Photo
        {
            get
            {
                if (_Photo == null)
                {
                    _Photo = new PhotoRepository(_repoContext);
                }

                return _Photo;
            }
        }

        private IPlageDensiteTemperatureRepository _PlageDensiteTemperature;

        public IPlageDensiteTemperatureRepository PlageDensiteTemperature
        {
            get
            {
                if (_PlageDensiteTemperature == null)
                {
                    _PlageDensiteTemperature = new PlageDensiteTemperatureRepository(_repoContext);
                }

                return _PlageDensiteTemperature;
            }
        }

        private IProduitRepository _Produit;

        public IProduitRepository Produit
        {
            get
            {
                if (_Produit == null)
                {
                    _Produit = new ProduitRepository(_repoContext);
                }

                return _Produit;
            }
        }

        private IProduitBacRepository _ProduitBac;

        public IProduitBacRepository ProduitBac
        {
            get
            {
                if (_ProduitBac == null)
                {
                    _ProduitBac = new ProduitBacRepository(_repoContext);
                }

                return _ProduitBac;
            }
        }

        private IProfilRepository _Profil;

        public IProfilRepository Profil
        {
            get
            {
                if (_Profil == null)
                {
                    _Profil = new ProfilRepository(_repoContext);
                }

                return _Profil;
            }
        }

        private IProfilFonctionnaliteRepository _ProfilFonctionnalite;

        public IProfilFonctionnaliteRepository ProfilFonctionnalite
        {
            get
            {
                if (_ProfilFonctionnalite == null)
                {
                    _ProfilFonctionnalite = new ProfilFonctionnaliteRepository(_repoContext);
                }

                return _ProfilFonctionnalite;
            }
        }

        private IReceptionProduitRepository _ReceptionProduit;

        public IReceptionProduitRepository ReceptionProduit
        {
            get
            {
                if (_ReceptionProduit == null)
                {
                    _ReceptionProduit = new ReceptionProduitRepository(_repoContext);
                }

                return _ReceptionProduit;
            }
        }

        private IStatutRepository _Statut;

        public IStatutRepository Statut
        {
            get
            {
                if (_Statut == null)
                {
                    _Statut = new StatutRepository(_repoContext);
                }

                return _Statut;
            }
        }

        private ITableBaremageRepository _TableBaremage;

        public ITableBaremageRepository TableBaremage
        {
            get
            {
                if (_TableBaremage == null)
                {
                    _TableBaremage = new TableBaremageRepository(_repoContext);
                }

                return _TableBaremage;
            }
        }

        private ITableVolumeDeplaceRepository _TableVolumeDeplace;

        public ITableVolumeDeplaceRepository TableVolumeDeplace
        {
            get
            {
                if (_TableVolumeDeplace == null)
                {
                    _TableVolumeDeplace = new TableVolumeDeplaceRepository(_repoContext);
                }

                return _TableVolumeDeplace;
            }
        }

        private ITransfertRepository _Transfert;

        public ITransfertRepository Transfert
        {
            get
            {
                if (_Transfert == null)
                {
                    _Transfert = new TransfertRepository(_repoContext);
                }

                return _Transfert;
            }
        }

        private ITypeBacRepository _TypeBac;

        public ITypeBacRepository TypeBac
        {
            get
            {
                if (_TypeBac == null)
                {
                    _TypeBac = new TypeBacRepository(_repoContext);
                }

                return _TypeBac;
            }
        }

        private ITypeProduitRepository _TypeProduit;

        public ITypeProduitRepository TypeProduit
        {
            get
            {
                if (_TypeProduit == null)
                {
                    _TypeProduit = new TypeProduitRepository(_repoContext);
                }

                return _TypeProduit;
            }
        }

        private ITypeToitRepository _TypeToit;

        public ITypeToitRepository TypeToit
        {
            get
            {
                if (_TypeToit == null)
                {
                    _TypeToit = new TypeToitRepository(_repoContext);
                }

                return _TypeToit;
            }
        }

        private IUniteMesureRepository _UniteMesure;

        public IUniteMesureRepository UniteMesure
        {
            get
            {
                if (_UniteMesure == null)
                {
                    _UniteMesure = new UniteMesureRepository(_repoContext);
                }

                return _UniteMesure;
            }
        }

        private IValeurConversionUniteRepository _ValeurConversionUnite;

        public IValeurConversionUniteRepository ValeurConversionUnite
        {
            get
            {
                if (_ValeurConversionUnite == null)
                {
                    _ValeurConversionUnite = new ValeurConversionUniteRepository(_repoContext);
                }

                return _ValeurConversionUnite;
            }
        }

    }
}
