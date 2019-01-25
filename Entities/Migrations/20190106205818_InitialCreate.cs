using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "psc");

            migrationBuilder.CreateTable(
                name: "caracteristique",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    grandeur_id = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristique", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fonctionnalite",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fonctionnalite", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "grandeur",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    symbole = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grandeur", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "histo_modif_envoi_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_envoi = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_envoi = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    operateur = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    provenance = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    hauteur_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    voulume_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    creer_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    modifier_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_envoye = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    create_jauge = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_cree = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    gsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    gsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_quize_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    observation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    temperature_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histo_modif_envoi_produit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "histo_modif_jauge",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_jauge = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_jauge = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    hauteur_jauge = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    observations = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    volume_jauge = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quize = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    id_statut_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    bsw = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_t = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histo_modif_jauge", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "histo_modif_reception_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_reception = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_reception = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    operateur = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    provenance = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    hauteur_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    voulume_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    creer_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    modifier_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_recu = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    create_jauge = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_cree = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    gsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    gsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_quize_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    observation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    temperature_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histo_modif_reception_produit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "histo_modif_transfert",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    hauteur = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    id_transfert = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_source_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_destination_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_transfert = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_source_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_destination_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac_source = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac_destination = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_source_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_destination_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze_bac_source = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant_bac_source = table.Column<double>(type: "double(32,2)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres_bac_source = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_source_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_destination_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_source_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_destination_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_source_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_destination_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_source = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_destination = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_histo_modif_transfert", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "licence",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    date_debut = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    date_fin = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    nombre_jour = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    module = table.Column<string>(unicode: false, maxLength: 255, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    is_active = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_licence", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Fonctionalite_id = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    LibelleMenu = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    Action = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    IdParent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    OrdreMenu = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    Controlleur = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    Url = table.Column<string>(unicode: false, maxLength: 250, nullable: true, defaultValueSql: "NULL"),
                    Icon = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "menu_profil",
                schema: "psc",
                columns: table => new
                {
                    menuid = table.Column<int>(type: "int(11)", nullable: false),
                    profilid = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu_profil", x => new { x.menuid, x.profilid });
                });

            migrationBuilder.CreateTable(
                name: "photo",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    extension = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    chemin_fichier = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "plage_densite_temperature",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    densite_a_quinze_min = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze_max = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature_min = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature_max = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pour_petrole_brut = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plage_densite_temperature", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "profil",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profil", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "statut",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statut", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_bac",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_bac", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_produit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type_toit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    correction_due_au_toit = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_toit", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "unite_mesure",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    libelle = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    id_grandeur = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    is_default = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    symbole = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    est_unite_reference = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    StatutCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unite_mesure", x => x.id);
                    table.ForeignKey(
                        name: "unite_mesure_ibfk_1",
                        column: x => x.id_grandeur,
                        principalSchema: "psc",
                        principalTable: "grandeur",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "agent",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_profil = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    login = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    mot_de_passe = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    nom = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    prenoms = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    contact = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    email = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    is_user = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    id_photo = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agent", x => x.id);
                    table.ForeignKey(
                        name: "agent_ibfk_2",
                        column: x => x.id_photo,
                        principalSchema: "psc",
                        principalTable: "photo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "agent_ibfk_1",
                        column: x => x.id_profil,
                        principalSchema: "psc",
                        principalTable: "profil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "profil_fonctionnalite",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_profil = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_fonctionnalite = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profil_fonctionnalite", x => x.id);
                    table.ForeignKey(
                        name: "profil_fonctionnalite_ibfk_2",
                        column: x => x.id_fonctionnalite,
                        principalSchema: "psc",
                        principalTable: "fonctionnalite",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "profil_fonctionnalite_ibfk_1",
                        column: x => x.id_profil,
                        principalSchema: "psc",
                        principalTable: "profil",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    designation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    id_type_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    dentite_a_quize_mini = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quize_maxi = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    est_pretrole_brut = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    StatutCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produit", x => x.id);
                    table.ForeignKey(
                        name: "produit_ibfk_1",
                        column: x => x.id_type_produit,
                        principalSchema: "psc",
                        principalTable: "type_produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "bac",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    repere = table.Column<string>(unicode: false, maxLength: 100, nullable: true, defaultValueSql: "NULL"),
                    id_type_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_debut = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    date_fin = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    id_type_toit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    diametre = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_total = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    date_derogation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    id_statut = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_mini_explotation = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_non_pompable = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    tonnage_brut = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    tonnage_net = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_total_reference = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_theorique = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_reel = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    masse_du_toit = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_mini_zone_incertitude = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_maxi_zone_incertitude = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_maximal_jauge = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bac", x => x.id);
                    table.ForeignKey(
                        name: "bac_ibfk_4",
                        column: x => x.id_statut,
                        principalSchema: "psc",
                        principalTable: "statut",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "bac_ibfk_2",
                        column: x => x.id_type_bac,
                        principalSchema: "psc",
                        principalTable: "type_bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "bac_ibfk_3",
                        column: x => x.id_type_toit,
                        principalSchema: "psc",
                        principalTable: "type_toit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "valeur_conversion_unite",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_unite_origine = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_unite_destination = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    valeur_conversion_origine = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    valeur_conversion_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    constante_conversion = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_valeur_conversion_unite", x => x.id);
                    table.ForeignKey(
                        name: "valeur_conversion_unite_ibfk_2",
                        column: x => x.id_unite_destination,
                        principalSchema: "psc",
                        principalTable: "unite_mesure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "valeur_conversion_unite_ibfk_1",
                        column: x => x.id_unite_origine,
                        principalSchema: "psc",
                        principalTable: "unite_mesure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "caracteristique_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_caracteristique = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_unite = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    valeur = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caracteristique_produit", x => x.id);
                    table.ForeignKey(
                        name: "caracteristique_produit_ibfk_2",
                        column: x => x.id_caracteristique,
                        principalSchema: "psc",
                        principalTable: "caracteristique",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "caracteristique_produit_ibfk_1",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "caracteristique_produit_ibfk_3",
                        column: x => x.id_unite,
                        principalSchema: "psc",
                        principalTable: "unite_mesure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "envoi_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_envoi = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    operateur = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    provenance = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    hauteur_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    voulume_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    creer_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    modifier_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_envoye = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    create_jauge = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_cree = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    gsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    gsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_quize_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    observation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_envoi_produit", x => x.id);
                    table.ForeignKey(
                        name: "envoi_produit_ibfk_2",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "envoi_produit_ibfk_1",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "historique_jauge",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_jauge = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    hauteur_jauge = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    observations = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    volume_jauge = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quize = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_statut_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    bsw = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_t = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historique_jauge", x => x.id);
                    table.ForeignKey(
                        name: "historique_jauge_ibfk_1",
                        column: x => x.id_agent,
                        principalSchema: "psc",
                        principalTable: "agent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "historique_jauge_ibfk_2",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "historique_jauge_ibfk_3",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "historique_jauge_ibfk_4",
                        column: x => x.id_statut_bac,
                        principalSchema: "psc",
                        principalTable: "statut",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "intervalle_baremage",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    debut = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    fin = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    sens_intervalle_debut = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    sens_intervalle_fin = table.Column<string>(unicode: false, maxLength: 50, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_intervalle_baremage", x => x.id);
                    table.ForeignKey(
                        name: "intervalle_baremage_ibfk_1",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "produit_bac",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    actif = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_mesure = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    id_unite = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quize = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_mesure = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_t = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produit_bac", x => x.id);
                    table.ForeignKey(
                        name: "produit_bac_ibfk_2",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "produit_bac_ibfk_1",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "produit_bac_ibfk_3",
                        column: x => x.id_unite,
                        principalSchema: "psc",
                        principalTable: "unite_mesure",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reception_produit",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_reception = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    operateur = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    provenance = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    hauteur_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    voulume_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_creux_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    creer_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    modifier_par = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    date_modification = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    vcf = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_recu = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    create_jauge = table.Column<short>(type: "bit(1)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_cree = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    gsv_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    gsv_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    pied_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    bsw_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_quize_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    correct_toit_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_eau_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    observation = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reception_produit", x => x.id);
                    table.ForeignKey(
                        name: "reception_produit_ibfk_2",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "reception_produit_ibfk_1",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "table_volume_deplace",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    ligne = table.Column<double>(type: "double(32,3)", nullable: true, defaultValueSql: "NULL"),
                    colonne = table.Column<double>(type: "double(32,3)", nullable: true, defaultValueSql: "NULL"),
                    volume_deplace = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_bac = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_volume_deplace", x => x.id);
                    table.ForeignKey(
                        name: "table_volume_deplace_ibfk_1",
                        column: x => x.id_bac,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "transfert",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    id_bac_source = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_bac_destination = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    hauteur = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    temperature = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    id_produit = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_source_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_destination_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    date_transfert = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    date_creation = table.Column<DateTime>(nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_source_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_destination_apres = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    id_agent = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_source_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_a_t_bac_destination_avant = table.Column<double>(type: "double(11,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze_bac_source = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    densite_a_quinze_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant_bac_source = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_avant_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres_bac_source = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    nsv_apres_bac_destination = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_source_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    hauteur_produit_bac_destination_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_source_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_destination_avant = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_source_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    volume_creux_bac_destination_apres = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_source = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    id_jauge_destination = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfert", x => x.id);
                    table.ForeignKey(
                        name: "transfert_ibfk_4",
                        column: x => x.id_agent,
                        principalSchema: "psc",
                        principalTable: "agent",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "transfert_ibfk_2",
                        column: x => x.id_bac_destination,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "transfert_ibfk_1",
                        column: x => x.id_bac_source,
                        principalSchema: "psc",
                        principalTable: "bac",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "transfert_ibfk_3",
                        column: x => x.id_produit,
                        principalSchema: "psc",
                        principalTable: "produit",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "table_baremage",
                schema: "psc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    valeur = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    coefficient = table.Column<double>(type: "double(32,4)", nullable: true, defaultValueSql: "NULL"),
                    id_intervalle_baremage = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL"),
                    StatusCode = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "NULL")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table_baremage", x => x.id);
                    table.ForeignKey(
                        name: "table_baremage_ibfk_1",
                        column: x => x.id_intervalle_baremage,
                        principalSchema: "psc",
                        principalTable: "intervalle_baremage",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "id_photo",
                schema: "psc",
                table: "agent",
                column: "id_photo");

            migrationBuilder.CreateIndex(
                name: "id_profil",
                schema: "psc",
                table: "agent",
                column: "id_profil");

            migrationBuilder.CreateIndex(
                name: "id_statut",
                schema: "psc",
                table: "bac",
                column: "id_statut");

            migrationBuilder.CreateIndex(
                name: "id_type_bac",
                schema: "psc",
                table: "bac",
                column: "id_type_bac");

            migrationBuilder.CreateIndex(
                name: "id_type_toit",
                schema: "psc",
                table: "bac",
                column: "id_type_toit");

            migrationBuilder.CreateIndex(
                name: "id_caracteristique",
                schema: "psc",
                table: "caracteristique_produit",
                column: "id_caracteristique");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "caracteristique_produit",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_unite",
                schema: "psc",
                table: "caracteristique_produit",
                column: "id_unite");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "envoi_produit",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "envoi_produit",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_agent",
                schema: "psc",
                table: "historique_jauge",
                column: "id_agent");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "historique_jauge",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "historique_jauge",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_statut_bac",
                schema: "psc",
                table: "historique_jauge",
                column: "id_statut_bac");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "intervalle_baremage",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_type_produit",
                schema: "psc",
                table: "produit",
                column: "id_type_produit");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "produit_bac",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "produit_bac",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_unite",
                schema: "psc",
                table: "produit_bac",
                column: "id_unite");

            migrationBuilder.CreateIndex(
                name: "id_fonctionnalite",
                schema: "psc",
                table: "profil_fonctionnalite",
                column: "id_fonctionnalite");

            migrationBuilder.CreateIndex(
                name: "id_profil",
                schema: "psc",
                table: "profil_fonctionnalite",
                column: "id_profil");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "reception_produit",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "reception_produit",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_intervalle_baremage",
                schema: "psc",
                table: "table_baremage",
                column: "id_intervalle_baremage");

            migrationBuilder.CreateIndex(
                name: "id_bac",
                schema: "psc",
                table: "table_volume_deplace",
                column: "id_bac");

            migrationBuilder.CreateIndex(
                name: "id_agent",
                schema: "psc",
                table: "transfert",
                column: "id_agent");

            migrationBuilder.CreateIndex(
                name: "id_bac_destination",
                schema: "psc",
                table: "transfert",
                column: "id_bac_destination");

            migrationBuilder.CreateIndex(
                name: "id_bac_source",
                schema: "psc",
                table: "transfert",
                column: "id_bac_source");

            migrationBuilder.CreateIndex(
                name: "id_produit",
                schema: "psc",
                table: "transfert",
                column: "id_produit");

            migrationBuilder.CreateIndex(
                name: "id_grandeur",
                schema: "psc",
                table: "unite_mesure",
                column: "id_grandeur");

            migrationBuilder.CreateIndex(
                name: "id_unite_destination",
                schema: "psc",
                table: "valeur_conversion_unite",
                column: "id_unite_destination");

            migrationBuilder.CreateIndex(
                name: "id_unite_origine",
                schema: "psc",
                table: "valeur_conversion_unite",
                column: "id_unite_origine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caracteristique_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "envoi_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "histo_modif_envoi_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "histo_modif_jauge",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "histo_modif_reception_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "histo_modif_transfert",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "historique_jauge",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "licence",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "menu",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "menu_profil",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "plage_densite_temperature",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "produit_bac",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "profil_fonctionnalite",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "reception_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "table_baremage",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "table_volume_deplace",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "transfert",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "valeur_conversion_unite",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "caracteristique",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "fonctionnalite",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "intervalle_baremage",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "agent",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "unite_mesure",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "bac",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "photo",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "profil",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "type_produit",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "grandeur",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "statut",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "type_bac",
                schema: "psc");

            migrationBuilder.DropTable(
                name: "type_toit",
                schema: "psc");
        }
    }
}
