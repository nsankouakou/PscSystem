using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Enumerations
{
   public static  class Const_TypeFormulaire
    {
        public const string DepotDeFonds = "02";
        public const string RecensementCabinets = "03";
        public const string RecensementAvocats = "04";
        public const string DemandeReglement = "05";
        public const string ValidationCheque = "06";
    }

   public static class Const_Security
   {
       public static String sCleCryptage = "CARPASERVICE";

   }
   public static class TypeCompteCarpa
   {
      public const string ComptePrincipal = "01";
      public const string CompteSequestre="02";
      public const string CompteEspèces="03";
      public const string CompteInvestissement = "04";
      public const string CompteExploitation = "05";
      public const string CompteCarpa = "06";
   }
   public static class Const_ParametresGeneraux
   {
       public const string MontantDepotMaxi = "01";
       public const string NombreJoursAvantRetrait = "02";
       public const string DomainName = "03";
       public const string Username = "04";
       public const string DomainAdminPassword = "05";
       public const string SiteCarpa = "06";
       public const string ChequeNumberDigits = "07";
       public const string LastChequeNumber = "08";
       public const string CodeChequePays = "09";
       public const string DomainServerIpAddress = "10";
       public const string ComptePourCheque = "11";
       public const string AdresseCompteCarpa = "12";
       public const string NumeroTelephoneCompteCarpa = "13";
       public const string NumeroFaxCompteCARPA = "14";
       public const string DelaiEnvoiSMS = "15";
       public const string EmailGestionnaire = "16";
       public const string NumeroGestionnaire = "17";
       public const string FrequenceEnvoiSMS = "18";
   }

   public static class Const_TypeEnregistrements
   {
       public const string Emetteur_AncienSolde = "01";
       public const string Emetteur_03 = "03";
       public const string Destinataire_Mouvement = "04";
       public const string Enregistrement_Details = "05";
       public const string Destinataire_06 = "06";
       public const string Total_NouveauSolde = "07";
       public const string Total_08 = "08";
   }

    public static class Views
    {
        public const string VwAffaireDepot ="";
        public const string VWAffaireParAvocat = "";
        public const string vwAffairesParAvocatouCabinet = "";
        public const string VwAffairesParCabinet = "";
        public const string VwAffairesParCompteCarpa = "";
        public const string VwAffairesParCompteCarpaModif = " EXECUTE dbo.PS_GetAffairesParCompteCarpa @NumCompte";
        public const string VwArborescenceComptes = "";
        public const string VwAvocatetComptesCarpa = "";
        public const string VwAvocatOrCabinetDepot = "";
        public const string VwAvocatsCabinets = "";
        public const string VwAvocatsCabinetsByLogin = "";
        public const string VwAvocatsetCabinets = "";
        public const string VwAvocatsetCabinetsModif = "";
        public const string VwAvocatsParCabinets = "";
        public const string VwCabinetAndComptes = "";
        public const string VwCabinetsCARPA = "";
        public const string VwChequeEmisaValider = "";
        public const string VwChequeEmisAvocatWithStatus = "";
        public const string VwChequeEmisWithStatus = "";
        public const string vwChequesetMouvements = "";
        public const string VwComptebanquaire = "";
        public const string VwComptesdelaCARPA = "";
        public const string vwContactsAvocats = "";
        public const string VwContactsCabinets = "";
        public const string VwDetailsCompteCarpaModif = "";
        public const string VwFluctuationCompteAvocat = "";
        public const string VwInfosStrategiques = "";
        public const string VwListeOperationsCompteCarpa = "";
        public const string VwmontantRetraitparAffaire = "";
        public const string VwMouvementCompteAvocat = "";
        public const string VwMouvementsAffaireCompteCARPAByLogin = "";
        public const string VwMouvementsAffaires = "";
        public const string VwMouvementsAffaireswithStatus = "";
        public const string VwMouvementsCabinetsOrAvocats = "";
        public const string VwPartCompteCarpa = "";
        public const string VwTransactionCompteCarpa = "";
    }


}
