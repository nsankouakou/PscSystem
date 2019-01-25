using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Entities.Models
{
    public partial class pscContext : DbContext
    {
        public pscContext()
        {
        }

        public pscContext(DbContextOptions<pscContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Bac> Bac { get; set; }
        public virtual DbSet<Caracteristique> Caracteristique { get; set; }
        public virtual DbSet<CaracteristiqueProduit> CaracteristiqueProduit { get; set; }
        public virtual DbSet<EnvoiProduit> EnvoiProduit { get; set; }
        public virtual DbSet<Fonctionnalite> Fonctionnalite { get; set; }
        public virtual DbSet<Grandeur> Grandeur { get; set; }
        public virtual DbSet<HistoModifEnvoiProduit> HistoModifEnvoiProduit { get; set; }
        public virtual DbSet<HistoModifJauge> HistoModifJauge { get; set; }
        public virtual DbSet<HistoModifReceptionProduit> HistoModifReceptionProduit { get; set; }
        public virtual DbSet<HistoModifTransfert> HistoModifTransfert { get; set; }
        public virtual DbSet<HistoriqueJauge> HistoriqueJauge { get; set; }
        public virtual DbSet<IntervalleBaremage> IntervalleBaremage { get; set; }
        public virtual DbSet<Licence> Licence { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuProfil> MenuProfil { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PlageDensiteTemperature> PlageDensiteTemperature { get; set; }
        public virtual DbSet<Produit> Produit { get; set; }
        public virtual DbSet<ProduitBac> ProduitBac { get; set; }
        public virtual DbSet<Profil> Profil { get; set; }
        public virtual DbSet<ProfilFonctionnalite> ProfilFonctionnalite { get; set; }
        public virtual DbSet<ReceptionProduit> ReceptionProduit { get; set; }
        public virtual DbSet<Statut> Statut { get; set; }
        public virtual DbSet<TableBaremage> TableBaremage { get; set; }
        public virtual DbSet<TableVolumeDeplace> TableVolumeDeplace { get; set; }
        public virtual DbSet<Transfert> Transfert { get; set; }
        public virtual DbSet<TypeBac> TypeBac { get; set; }
        public virtual DbSet<TypeProduit> TypeProduit { get; set; }
        public virtual DbSet<TypeToit> TypeToit { get; set; }
        public virtual DbSet<UniteMesure> UniteMesure { get; set; }
        public virtual DbSet<ValeurConversionUnite> ValeurConversionUnite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=AblahA0815;database=psc");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.ToTable("agent", "psc");

                entity.HasIndex(e => e.IdPhoto)
                    .HasName("id_photo");

                entity.HasIndex(e => e.IdProfil)
                    .HasName("id_profil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdPhoto)
                    .HasColumnName("id_photo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProfil)
                    .HasColumnName("id_profil")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IsUser)
                    .HasColumnName("is_user")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MotDePasse)
                    .HasColumnName("mot_de_passe")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Prenoms)
                    .HasColumnName("prenoms")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdPhotoNavigation)
                    .WithMany(p => p.Agent)
                    .HasForeignKey(d => d.IdPhoto)
                    .HasConstraintName("agent_ibfk_2");

                entity.HasOne(d => d.IdProfilNavigation)
                    .WithMany(p => p.Agent)
                    .HasForeignKey(d => d.IdProfil)
                    .HasConstraintName("agent_ibfk_1");
            });

            modelBuilder.Entity<Bac>(entity =>
            {
                entity.ToTable("bac", "psc");

                entity.HasIndex(e => e.IdStatut)
                    .HasName("id_statut");

                entity.HasIndex(e => e.IdTypeBac)
                    .HasName("id_type_bac");

                entity.HasIndex(e => e.IdTypeToit)
                    .HasName("id_type_toit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateDebut)
                    .HasColumnName("date_debut")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateDerogation)
                    .HasColumnName("date_derogation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateFin)
                    .HasColumnName("date_fin")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Diametre)
                    .HasColumnName("diametre")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurMaxiZoneIncertitude)
                    .HasColumnName("hauteur_maxi_zone_incertitude")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurMaximalJauge)
                    .HasColumnName("hauteur_maximal_jauge")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurMiniExplotation)
                    .HasColumnName("hauteur_mini_explotation")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurMiniZoneIncertitude)
                    .HasColumnName("hauteur_mini_zone_incertitude")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurTotalReference)
                    .HasColumnName("hauteur_total_reference")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdStatut)
                    .HasColumnName("id_statut")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdTypeBac)
                    .HasColumnName("id_type_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdTypeToit)
                    .HasColumnName("id_type_toit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.MasseDuToit)
                    .HasColumnName("masse_du_toit")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Repere)
                    .HasColumnName("repere")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TonnageBrut)
                    .HasColumnName("tonnage_brut")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TonnageNet)
                    .HasColumnName("tonnage_net")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeNonPompable)
                    .HasColumnName("volume_non_pompable")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeReel)
                    .HasColumnName("volume_reel")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeTheorique)
                    .HasColumnName("volume_theorique")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeTotal)
                    .HasColumnName("volume_total")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdStatutNavigation)
                    .WithMany(p => p.Bac)
                    .HasForeignKey(d => d.IdStatut)
                    .HasConstraintName("bac_ibfk_4");

                entity.HasOne(d => d.IdTypeBacNavigation)
                    .WithMany(p => p.Bac)
                    .HasForeignKey(d => d.IdTypeBac)
                    .HasConstraintName("bac_ibfk_2");

                entity.HasOne(d => d.IdTypeToitNavigation)
                    .WithMany(p => p.Bac)
                    .HasForeignKey(d => d.IdTypeToit)
                    .HasConstraintName("bac_ibfk_3");
            });

            modelBuilder.Entity<Caracteristique>(entity =>
            {
                entity.ToTable("caracteristique", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GrandeurId)
                    .HasColumnName("grandeur_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<CaracteristiqueProduit>(entity =>
            {
                entity.ToTable("caracteristique_produit", "psc");

                entity.HasIndex(e => e.IdCaracteristique)
                    .HasName("id_caracteristique");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.HasIndex(e => e.IdUnite)
                    .HasName("id_unite");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCaracteristique)
                    .HasColumnName("id_caracteristique")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdUnite)
                    .HasColumnName("id_unite")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Valeur)
                    .HasColumnName("valeur")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdCaracteristiqueNavigation)
                    .WithMany(p => p.CaracteristiqueProduit)
                    .HasForeignKey(d => d.IdCaracteristique)
                    .HasConstraintName("caracteristique_produit_ibfk_2");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.CaracteristiqueProduit)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("caracteristique_produit_ibfk_1");

                entity.HasOne(d => d.IdUniteNavigation)
                    .WithMany(p => p.CaracteristiqueProduit)
                    .HasForeignKey(d => d.IdUnite)
                    .HasConstraintName("caracteristique_produit_ibfk_3");
            });

            modelBuilder.Entity<EnvoiProduit>(entity =>
            {
                entity.ToTable("envoi_produit", "psc");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BswApres)
                    .HasColumnName("bsw_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BswAvant)
                    .HasColumnName("bsw_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitApres)
                    .HasColumnName("correct_toit_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitAvant)
                    .HasColumnName("correct_toit_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreateJauge)
                    .HasColumnName("create_jauge")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreerPar)
                    .HasColumnName("creer_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateEnvoi)
                    .HasColumnName("date_envoi")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinze)
                    .HasColumnName("densite_a_quinze")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteQuizeAvant)
                    .HasColumnName("densite_quize_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvApres)
                    .HasColumnName("gsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvAvant)
                    .HasColumnName("gsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurApres)
                    .HasColumnName("hauteur_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurAvant)
                    .HasColumnName("hauteur_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxApres)
                    .HasColumnName("hauteur_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxAvant)
                    .HasColumnName("hauteur_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeCree)
                    .HasColumnName("id_jauge_cree")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModifierPar)
                    .HasColumnName("modifier_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApres)
                    .HasColumnName("nsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvant)
                    .HasColumnName("nsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observation)
                    .HasColumnName("observation")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Operateur)
                    .HasColumnName("operateur")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauApres)
                    .HasColumnName("pied_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauAvant)
                    .HasColumnName("pied_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Provenance)
                    .HasColumnName("provenance")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureAvant)
                    .HasColumnName("temperature_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeApres)
                    .HasColumnName("volume_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeAvant)
                    .HasColumnName("volume_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxApres)
                    .HasColumnName("volume_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauApres)
                    .HasColumnName("volume_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauAvant)
                    .HasColumnName("volume_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEnvoye)
                    .HasColumnName("volume_envoye")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VoulumeCreuxAvant)
                    .HasColumnName("voulume_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.EnvoiProduit)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("envoi_produit_ibfk_2");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.EnvoiProduit)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("envoi_produit_ibfk_1");
            });

            modelBuilder.Entity<Fonctionnalite>(entity =>
            {
                entity.ToTable("fonctionnalite", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Grandeur>(entity =>
            {
                entity.ToTable("grandeur", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Symbole)
                    .HasColumnName("symbole")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<HistoModifEnvoiProduit>(entity =>
            {
                entity.ToTable("histo_modif_envoi_produit", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BswApres)
                    .HasColumnName("bsw_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BswAvant)
                    .HasColumnName("bsw_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitApres)
                    .HasColumnName("correct_toit_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitAvant)
                    .HasColumnName("correct_toit_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreateJauge)
                    .HasColumnName("create_jauge")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreerPar)
                    .HasColumnName("creer_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateEnvoi)
                    .HasColumnName("date_envoi")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinze)
                    .HasColumnName("densite_a_quinze")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteQuizeAvant)
                    .HasColumnName("densite_quize_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvApres)
                    .HasColumnName("gsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvAvant)
                    .HasColumnName("gsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurApres)
                    .HasColumnName("hauteur_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurAvant)
                    .HasColumnName("hauteur_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxApres)
                    .HasColumnName("hauteur_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxAvant)
                    .HasColumnName("hauteur_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdEnvoi)
                    .HasColumnName("id_envoi")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeCree)
                    .HasColumnName("id_jauge_cree")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModifierPar)
                    .HasColumnName("modifier_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApres)
                    .HasColumnName("nsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvant)
                    .HasColumnName("nsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observation)
                    .HasColumnName("observation")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Operateur)
                    .HasColumnName("operateur")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauApres)
                    .HasColumnName("pied_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauAvant)
                    .HasColumnName("pied_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Provenance)
                    .HasColumnName("provenance")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureAvant)
                    .HasColumnName("temperature_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeApres)
                    .HasColumnName("volume_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeAvant)
                    .HasColumnName("volume_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxApres)
                    .HasColumnName("volume_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauApres)
                    .HasColumnName("volume_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauAvant)
                    .HasColumnName("volume_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEnvoye)
                    .HasColumnName("volume_envoye")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VoulumeCreuxAvant)
                    .HasColumnName("voulume_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<HistoModifJauge>(entity =>
            {
                entity.ToTable("histo_modif_jauge", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bsw)
                    .HasColumnName("bsw")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToit)
                    .HasColumnName("correct_toit")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateJauge)
                    .HasColumnName("date_jauge")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuize)
                    .HasColumnName("densite_a_quize")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAT)
                    .HasColumnName("densite_a_t")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurJauge)
                    .HasColumnName("hauteur_jauge")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJauge)
                    .HasColumnName("id_jauge")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdStatutBac)
                    .HasColumnName("id_statut_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEau)
                    .HasColumnName("pied_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreux)
                    .HasColumnName("volume_creux")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEau)
                    .HasColumnName("volume_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeJauge)
                    .HasColumnName("volume_jauge")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<HistoModifReceptionProduit>(entity =>
            {
                entity.ToTable("histo_modif_reception_produit", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BswApres)
                    .HasColumnName("bsw_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BswAvant)
                    .HasColumnName("bsw_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitApres)
                    .HasColumnName("correct_toit_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitAvant)
                    .HasColumnName("correct_toit_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreateJauge)
                    .HasColumnName("create_jauge")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreerPar)
                    .HasColumnName("creer_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateReception)
                    .HasColumnName("date_reception")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinze)
                    .HasColumnName("densite_a_quinze")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteQuizeAvant)
                    .HasColumnName("densite_quize_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvApres)
                    .HasColumnName("gsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvAvant)
                    .HasColumnName("gsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurApres)
                    .HasColumnName("hauteur_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurAvant)
                    .HasColumnName("hauteur_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxApres)
                    .HasColumnName("hauteur_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxAvant)
                    .HasColumnName("hauteur_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeCree)
                    .HasColumnName("id_jauge_cree")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdReception)
                    .HasColumnName("id_reception")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModifierPar)
                    .HasColumnName("modifier_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Nsv)
                    .HasColumnName("nsv")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApres)
                    .HasColumnName("nsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvant)
                    .HasColumnName("nsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observation)
                    .HasColumnName("observation")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Operateur)
                    .HasColumnName("operateur")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauApres)
                    .HasColumnName("pied_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauAvant)
                    .HasColumnName("pied_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Provenance)
                    .HasColumnName("provenance")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureAvant)
                    .HasColumnName("temperature_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeApres)
                    .HasColumnName("volume_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeAvant)
                    .HasColumnName("volume_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxApres)
                    .HasColumnName("volume_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauApres)
                    .HasColumnName("volume_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauAvant)
                    .HasColumnName("volume_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeRecu)
                    .HasColumnName("volume_recu")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VoulumeCreuxAvant)
                    .HasColumnName("voulume_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<HistoModifTransfert>(entity =>
            {
                entity.ToTable("histo_modif_transfert", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateTransfert)
                    .HasColumnName("date_transfert")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeBacDestination)
                    .HasColumnName("densite_a_quinze_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeBacSource)
                    .HasColumnName("densite_a_quinze_bac_source")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Hauteur)
                    .HasColumnName("hauteur")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacDestinationApres)
                    .HasColumnName("hauteur_produit_bac_destination_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacDestinationAvant)
                    .HasColumnName("hauteur_produit_bac_destination_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacSourceApres)
                    .HasColumnName("hauteur_produit_bac_source_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacSourceAvant)
                    .HasColumnName("hauteur_produit_bac_source_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBacDestination)
                    .HasColumnName("id_bac_destination")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBacSource)
                    .HasColumnName("id_bac_source")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeDestination)
                    .HasColumnName("id_jauge_destination")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeSource)
                    .HasColumnName("id_jauge_source")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdTransfert)
                    .HasColumnName("id_transfert")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApresBacDestination)
                    .HasColumnName("nsv_apres_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApresBacSource)
                    .HasColumnName("nsv_apres_bac_source")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvantBacDestination)
                    .HasColumnName("nsv_avant_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvantBacSource)
                    .HasColumnName("nsv_avant_bac_source")
                    .HasColumnType("double(32,2)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacDestinationApres)
                    .HasColumnName("volume_a_t_bac_destination_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacDestinationAvant)
                    .HasColumnName("volume_a_t_bac_destination_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacSourceApres)
                    .HasColumnName("volume_a_t_bac_source_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacSourceAvant)
                    .HasColumnName("volume_a_t_bac_source_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacDestinationApres)
                    .HasColumnName("volume_creux_bac_destination_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacDestinationAvant)
                    .HasColumnName("volume_creux_bac_destination_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacSourceApres)
                    .HasColumnName("volume_creux_bac_source_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacSourceAvant)
                    .HasColumnName("volume_creux_bac_source_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<HistoriqueJauge>(entity =>
            {
                entity.ToTable("historique_jauge", "psc");

                entity.HasIndex(e => e.IdAgent)
                    .HasName("id_agent");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.HasIndex(e => e.IdStatutBac)
                    .HasName("id_statut_bac");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bsw)
                    .HasColumnName("bsw")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToit)
                    .HasColumnName("correct_toit")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateJauge)
                    .HasColumnName("date_jauge")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuize)
                    .HasColumnName("densite_a_quize")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAT)
                    .HasColumnName("densite_a_t")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurJauge)
                    .HasColumnName("hauteur_jauge")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdStatutBac)
                    .HasColumnName("id_statut_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observations)
                    .HasColumnName("observations")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEau)
                    .HasColumnName("pied_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreux)
                    .HasColumnName("volume_creux")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEau)
                    .HasColumnName("volume_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeJauge)
                    .HasColumnName("volume_jauge")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdAgentNavigation)
                    .WithMany(p => p.HistoriqueJauge)
                    .HasForeignKey(d => d.IdAgent)
                    .HasConstraintName("historique_jauge_ibfk_1");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.HistoriqueJauge)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("historique_jauge_ibfk_2");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.HistoriqueJauge)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("historique_jauge_ibfk_3");

                entity.HasOne(d => d.IdStatutBacNavigation)
                    .WithMany(p => p.HistoriqueJauge)
                    .HasForeignKey(d => d.IdStatutBac)
                    .HasConstraintName("historique_jauge_ibfk_4");
            });

            modelBuilder.Entity<IntervalleBaremage>(entity =>
            {
                entity.ToTable("intervalle_baremage", "psc");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Debut)
                    .HasColumnName("debut")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Fin)
                    .HasColumnName("fin")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SensIntervalleDebut)
                    .HasColumnName("sens_intervalle_debut")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.SensIntervalleFin)
                    .HasColumnName("sens_intervalle_fin")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.IntervalleBaremage)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("intervalle_baremage_ibfk_1");
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.ToTable("licence", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateDebut)
                    .HasColumnName("date_debut")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateFin)
                    .HasColumnName("date_fin")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IsActive)
                    .HasColumnName("is_active")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Module)
                    .HasColumnName("module")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NombreJour)
                    .HasColumnName("nombre_jour")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("menu", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Controlleur)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FonctionaliteId)
                    .HasColumnName("Fonctionalite_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Icon)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdParent)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.LibelleMenu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OrdreMenu)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<MenuProfil>(entity =>
            {
                entity.HasKey(e => new { e.Menuid, e.Profilid });

                entity.ToTable("menu_profil", "psc");

                entity.Property(e => e.Menuid)
                    .HasColumnName("menuid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Profilid)
                    .HasColumnName("profilid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("photo", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheminFichier)
                    .HasColumnName("chemin_fichier")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<PlageDensiteTemperature>(entity =>
            {
                entity.ToTable("plage_densite_temperature", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeMax)
                    .HasColumnName("densite_a_quinze_max")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeMin)
                    .HasColumnName("densite_a_quinze_min")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PourPetroleBrut)
                    .HasColumnName("pour_petrole_brut")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureMax)
                    .HasColumnName("temperature_max")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureMin)
                    .HasColumnName("temperature_min")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<Produit>(entity =>
            {
                entity.ToTable("produit", "psc");

                entity.HasIndex(e => e.IdTypeProduit)
                    .HasName("id_type_produit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuizeMaxi)
                    .HasColumnName("densite_a_quize_maxi")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DentiteAQuizeMini)
                    .HasColumnName("dentite_a_quize_mini")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstPretroleBrut)
                    .HasColumnName("est_pretrole_brut")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdTypeProduit)
                    .HasColumnName("id_type_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatutCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdTypeProduitNavigation)
                    .WithMany(p => p.Produit)
                    .HasForeignKey(d => d.IdTypeProduit)
                    .HasConstraintName("produit_ibfk_1");
            });

            modelBuilder.Entity<ProduitBac>(entity =>
            {
                entity.ToTable("produit_bac", "psc");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.HasIndex(e => e.IdUnite)
                    .HasName("id_unite");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actif)
                    .HasColumnName("actif")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Bsw)
                    .HasColumnName("bsw")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToit)
                    .HasColumnName("correct_toit")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuize)
                    .HasColumnName("densite_a_quize")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAT)
                    .HasColumnName("densite_a_t")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurMesure)
                    .HasColumnName("hauteur_mesure")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdUnite)
                    .HasColumnName("id_unite")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEau)
                    .HasColumnName("pied_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEau)
                    .HasColumnName("volume_eau")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeMesure)
                    .HasColumnName("volume_mesure")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.ProduitBac)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("produit_bac_ibfk_2");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ProduitBac)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("produit_bac_ibfk_1");

                entity.HasOne(d => d.IdUniteNavigation)
                    .WithMany(p => p.ProduitBac)
                    .HasForeignKey(d => d.IdUnite)
                    .HasConstraintName("produit_bac_ibfk_3");
            });

            modelBuilder.Entity<Profil>(entity =>
            {
                entity.ToTable("profil", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<ProfilFonctionnalite>(entity =>
            {
                entity.ToTable("profil_fonctionnalite", "psc");

                entity.HasIndex(e => e.IdFonctionnalite)
                    .HasName("id_fonctionnalite");

                entity.HasIndex(e => e.IdProfil)
                    .HasName("id_profil");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdFonctionnalite)
                    .HasColumnName("id_fonctionnalite")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProfil)
                    .HasColumnName("id_profil")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdFonctionnaliteNavigation)
                    .WithMany(p => p.ProfilFonctionnalite)
                    .HasForeignKey(d => d.IdFonctionnalite)
                    .HasConstraintName("profil_fonctionnalite_ibfk_2");

                entity.HasOne(d => d.IdProfilNavigation)
                    .WithMany(p => p.ProfilFonctionnalite)
                    .HasForeignKey(d => d.IdProfil)
                    .HasConstraintName("profil_fonctionnalite_ibfk_1");
            });

            modelBuilder.Entity<ReceptionProduit>(entity =>
            {
                entity.ToTable("reception_produit", "psc");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BswApres)
                    .HasColumnName("bsw_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.BswAvant)
                    .HasColumnName("bsw_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitApres)
                    .HasColumnName("correct_toit_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CorrectToitAvant)
                    .HasColumnName("correct_toit_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreateJauge)
                    .HasColumnName("create_jauge")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.CreerPar)
                    .HasColumnName("creer_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateModification)
                    .HasColumnName("date_modification")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateReception)
                    .HasColumnName("date_reception")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinze)
                    .HasColumnName("densite_a_quinze")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteQuizeAvant)
                    .HasColumnName("densite_quize_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvApres)
                    .HasColumnName("gsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.GsvAvant)
                    .HasColumnName("gsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurApres)
                    .HasColumnName("hauteur_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurAvant)
                    .HasColumnName("hauteur_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxApres)
                    .HasColumnName("hauteur_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurCreuxAvant)
                    .HasColumnName("hauteur_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeCree)
                    .HasColumnName("id_jauge_cree")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ModifierPar)
                    .HasColumnName("modifier_par")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApres)
                    .HasColumnName("nsv_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvant)
                    .HasColumnName("nsv_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Observation)
                    .HasColumnName("observation")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Operateur)
                    .HasColumnName("operateur")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauApres)
                    .HasColumnName("pied_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.PiedEauAvant)
                    .HasColumnName("pied_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Provenance)
                    .HasColumnName("provenance")
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TemperatureAvant)
                    .HasColumnName("temperature_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Vcf)
                    .HasColumnName("vcf")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeApres)
                    .HasColumnName("volume_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeAvant)
                    .HasColumnName("volume_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxApres)
                    .HasColumnName("volume_creux_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauApres)
                    .HasColumnName("volume_eau_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeEauAvant)
                    .HasColumnName("volume_eau_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeRecu)
                    .HasColumnName("volume_recu")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VoulumeCreuxAvant)
                    .HasColumnName("voulume_creux_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.ReceptionProduit)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("reception_produit_ibfk_2");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.ReceptionProduit)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("reception_produit_ibfk_1");
            });

            modelBuilder.Entity<Statut>(entity =>
            {
                entity.ToTable("statut", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<TableBaremage>(entity =>
            {
                entity.ToTable("table_baremage", "psc");

                entity.HasIndex(e => e.IdIntervalleBaremage)
                    .HasName("id_intervalle_baremage");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Coefficient)
                    .HasColumnName("coefficient")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdIntervalleBaremage)
                    .HasColumnName("id_intervalle_baremage")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Valeur)
                    .HasColumnName("valeur")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdIntervalleBaremageNavigation)
                    .WithMany(p => p.TableBaremage)
                    .HasForeignKey(d => d.IdIntervalleBaremage)
                    .HasConstraintName("table_baremage_ibfk_1");
            });

            modelBuilder.Entity<TableVolumeDeplace>(entity =>
            {
                entity.ToTable("table_volume_deplace", "psc");

                entity.HasIndex(e => e.IdBac)
                    .HasName("id_bac");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Colonne)
                    .HasColumnName("colonne")
                    .HasColumnType("double(32,3)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBac)
                    .HasColumnName("id_bac")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Ligne)
                    .HasColumnName("ligne")
                    .HasColumnType("double(32,3)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeDeplace)
                    .HasColumnName("volume_deplace")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdBacNavigation)
                    .WithMany(p => p.TableVolumeDeplace)
                    .HasForeignKey(d => d.IdBac)
                    .HasConstraintName("table_volume_deplace_ibfk_1");
            });

            modelBuilder.Entity<Transfert>(entity =>
            {
                entity.ToTable("transfert", "psc");

                entity.HasIndex(e => e.IdAgent)
                    .HasName("id_agent");

                entity.HasIndex(e => e.IdBacDestination)
                    .HasName("id_bac_destination");

                entity.HasIndex(e => e.IdBacSource)
                    .HasName("id_bac_source");

                entity.HasIndex(e => e.IdProduit)
                    .HasName("id_produit");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateTransfert)
                    .HasColumnName("date_transfert")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeBacDestination)
                    .HasColumnName("densite_a_quinze_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DensiteAQuinzeBacSource)
                    .HasColumnName("densite_a_quinze_bac_source")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Hauteur)
                    .HasColumnName("hauteur")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacDestinationApres)
                    .HasColumnName("hauteur_produit_bac_destination_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacDestinationAvant)
                    .HasColumnName("hauteur_produit_bac_destination_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacSourceApres)
                    .HasColumnName("hauteur_produit_bac_source_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.HauteurProduitBacSourceAvant)
                    .HasColumnName("hauteur_produit_bac_source_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdAgent)
                    .HasColumnName("id_agent")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBacDestination)
                    .HasColumnName("id_bac_destination")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdBacSource)
                    .HasColumnName("id_bac_source")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeDestination)
                    .HasColumnName("id_jauge_destination")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdJaugeSource)
                    .HasColumnName("id_jauge_source")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdProduit)
                    .HasColumnName("id_produit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApresBacDestination)
                    .HasColumnName("nsv_apres_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvApresBacSource)
                    .HasColumnName("nsv_apres_bac_source")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvantBacDestination)
                    .HasColumnName("nsv_avant_bac_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.NsvAvantBacSource)
                    .HasColumnName("nsv_avant_bac_source")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacDestinationApres)
                    .HasColumnName("volume_a_t_bac_destination_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacDestinationAvant)
                    .HasColumnName("volume_a_t_bac_destination_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacSourceApres)
                    .HasColumnName("volume_a_t_bac_source_apres")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeATBacSourceAvant)
                    .HasColumnName("volume_a_t_bac_source_avant")
                    .HasColumnType("double(11,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacDestinationApres)
                    .HasColumnName("volume_creux_bac_destination_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacDestinationAvant)
                    .HasColumnName("volume_creux_bac_destination_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacSourceApres)
                    .HasColumnName("volume_creux_bac_source_apres")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.VolumeCreuxBacSourceAvant)
                    .HasColumnName("volume_creux_bac_source_avant")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdAgentNavigation)
                    .WithMany(p => p.Transfert)
                    .HasForeignKey(d => d.IdAgent)
                    .HasConstraintName("transfert_ibfk_4");

                entity.HasOne(d => d.IdBacDestinationNavigation)
                    .WithMany(p => p.TransfertIdBacDestinationNavigation)
                    .HasForeignKey(d => d.IdBacDestination)
                    .HasConstraintName("transfert_ibfk_2");

                entity.HasOne(d => d.IdBacSourceNavigation)
                    .WithMany(p => p.TransfertIdBacSourceNavigation)
                    .HasForeignKey(d => d.IdBacSource)
                    .HasConstraintName("transfert_ibfk_1");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.Transfert)
                    .HasForeignKey(d => d.IdProduit)
                    .HasConstraintName("transfert_ibfk_3");
            });

            modelBuilder.Entity<TypeBac>(entity =>
            {
                entity.ToTable("type_bac", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<TypeProduit>(entity =>
            {
                entity.ToTable("type_produit", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<TypeToit>(entity =>
            {
                entity.ToTable("type_toit", "psc");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectionDueAuToit)
                    .HasColumnName("correction_due_au_toit")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<UniteMesure>(entity =>
            {
                entity.ToTable("unite_mesure", "psc");

                entity.HasIndex(e => e.IdGrandeur)
                    .HasName("id_grandeur");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.EstUniteReference)
                    .HasColumnName("est_unite_reference")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdGrandeur)
                    .HasColumnName("id_grandeur")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("is_default")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Libelle)
                    .HasColumnName("libelle")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatutCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Symbole)
                    .HasColumnName("symbole")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdGrandeurNavigation)
                    .WithMany(p => p.UniteMesure)
                    .HasForeignKey(d => d.IdGrandeur)
                    .HasConstraintName("unite_mesure_ibfk_1");
            });

            modelBuilder.Entity<ValeurConversionUnite>(entity =>
            {
                entity.ToTable("valeur_conversion_unite", "psc");

                entity.HasIndex(e => e.IdUniteDestination)
                    .HasName("id_unite_destination");

                entity.HasIndex(e => e.IdUniteOrigine)
                    .HasName("id_unite_origine");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstanteConversion)
                    .HasColumnName("constante_conversion")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.DateCreation)
                    .HasColumnName("date_creation")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdUniteDestination)
                    .HasColumnName("id_unite_destination")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.IdUniteOrigine)
                    .HasColumnName("id_unite_origine")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StatusCode)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ValeurConversionDestination)
                    .HasColumnName("valeur_conversion_destination")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.ValeurConversionOrigine)
                    .HasColumnName("valeur_conversion_origine")
                    .HasColumnType("double(32,4)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.IdUniteDestinationNavigation)
                    .WithMany(p => p.ValeurConversionUniteIdUniteDestinationNavigation)
                    .HasForeignKey(d => d.IdUniteDestination)
                    .HasConstraintName("valeur_conversion_unite_ibfk_2");

                entity.HasOne(d => d.IdUniteOrigineNavigation)
                    .WithMany(p => p.ValeurConversionUniteIdUniteOrigineNavigation)
                    .HasForeignKey(d => d.IdUniteOrigine)
                    .HasConstraintName("valeur_conversion_unite_ibfk_1");
            });
        }
    }
}
