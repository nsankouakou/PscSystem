using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Enumerations
{
    public class Enumeration
    {
       
        public enum StatutCodeDemande
        {

            DonneesClienteles = 1,
            PlanificationRDV = 2,
            CompteRendu = 3,
            DemandeComplete = 4,
            AucunStatus = 0

        }
        public enum enumEtat
        {
            Non_Valide = 0,
            Valide = 1
        }

        #region StatusCompteUtilisateur 

        public enum StatusCompteUtilisateur
        {
            Actif = 1,
            Inactif,
            Verrouille,
            VerrouilleOuvertureSession
        };

        #endregion

        #region StatusEnvoiMail

        public enum StatusEnvoiMail
        {
            NonEnvoyer = 0,
            Envoyer
        };

        #endregion
        //1=FOURNIR PAR SNE, 2 = FOURNIR PAR L'ABONNE
        #region StatusComposant

        public enum StatusComposant
        {
            InclureDansDevis = 1,
            InclureDansBonCommande = 2,
            EstAvanceSurConso = 3
        };

        #endregion
        #region StatusEnvoiSms

        public enum StatusEnvoiSms
        {
            NonEnvoyer = 0,
            Envoyer
        };

        #endregion

        #region StatusRejet

        public enum StatusRejet
        {
            PasRejeter = 0,
            Rejeter = 1
        };

        #endregion



        #region "Operation de Validation" 
        public enum OperationValidation
        {
            valider = 0,
            rejeter,
            envoyer
        }
        #endregion





        #region StatusCode

        public enum StatutCode
        {
            Actif = 1,
            Inactif = 2
        };

        public enum StateCode
        {
            Actif = 0,
            Inactif = 1
        };

        public enum StatutCompteur
        {
            Transferer = 1,
            Affecter = 2,

            Existant = 3
        };

        #endregion

        #region StateCode


        public enum statutCodeStock
        {
            Transfere = 1,
            Affecte = 2
        };




        #endregion

        #region AgentEPTFonction

        public enum AgentEPTFonction
        {
            AgentEtude = 1,
            AgentBranchement = 2,
            AgentCommercial = 3

        };

        #endregion

       

    }
}
