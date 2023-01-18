﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SerieDLL_EF.BDD;

#nullable disable

namespace SerieDLLEF.Migrations
{
    [DbContext(typeof(BddprojetContext))]
    [Migration("20230113195357_InitMig")]
    partial class InitMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SerieDLL_EF.Models.Acteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.Property<string>("Prenom")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("prenom");

                    b.HasKey("Id")
                        .HasName("PK__acteur__3213E83F012BD232");

                    b.ToTable("acteur", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DatePremDiff")
                        .HasColumnType("date")
                        .HasColumnName("date_prem_diff");

                    b.Property<string>("Nom")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.Property<string>("Resume")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("resume");

                    b.Property<int>("SaisonId")
                        .HasColumnType("int")
                        .HasColumnName("saison_id");

                    b.HasKey("Id")
                        .HasName("PK__episode__3213E83F07132552");

                    b.ToTable("episode", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Personnage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActeurId")
                        .HasColumnType("int")
                        .HasColumnName("acteur_id");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.Property<int>("SerieId")
                        .HasColumnType("int")
                        .HasColumnName("serie_id");

                    b.HasKey("Id")
                        .HasName("PK__personna__3213E83F9D3A7249");

                    b.HasIndex("ActeurId");

                    b.HasIndex("SerieId");

                    b.ToTable("personnage", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Saison", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NbEpisode")
                        .HasColumnType("int")
                        .HasColumnName("nb_episode");

                    b.Property<short>("Numero")
                        .HasColumnType("smallint")
                        .HasColumnName("numero");

                    b.Property<int>("SerieId")
                        .HasColumnType("int")
                        .HasColumnName("serie_id");

                    b.HasKey("Id")
                        .HasName("PK__saison__3213E83FAFFCF90F");

                    b.HasIndex("SerieId");

                    b.ToTable("saison", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Serie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Affiche")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("affiche");

                    b.Property<DateTime?>("DateDiff")
                        .HasColumnType("date")
                        .HasColumnName("date_diff");

                    b.Property<string>("Nom")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("nom");

                    b.Property<string>("Resume")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("resume");

                    b.Property<string>("UrlBa")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("url_ba");

                    b.HasKey("Id")
                        .HasName("PK__serie__3213E83F1A62E8C0");

                    b.ToTable("serie", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.UserApp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<int>("Roles")
                        .HasColumnType("int")
                        .HasColumnName("roles");

                    b.Property<string>("ToWatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("WatchList");

                    b.HasKey("Id")
                        .HasName("PK__userApp__3213E83F7BE5A89E");

                    b.ToTable("userApp", (string)null);
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Personnage", b =>
                {
                    b.HasOne("SerieDLL_EF.Models.Acteur", "Acteur")
                        .WithMany("Personnages")
                        .HasForeignKey("ActeurId")
                        .IsRequired()
                        .HasConstraintName("FK__personnag__acteu__38996AB5");

                    b.HasOne("SerieDLL_EF.Models.Serie", "Serie")
                        .WithMany("Personnages")
                        .HasForeignKey("SerieId")
                        .IsRequired()
                        .HasConstraintName("FK__personnag__serie__398D8EEE");

                    b.Navigation("Acteur");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Saison", b =>
                {
                    b.HasOne("SerieDLL_EF.Models.Serie", "Serie")
                        .WithMany("Saisons")
                        .HasForeignKey("SerieId")
                        .IsRequired()
                        .HasConstraintName("FK__saison__serie_id__3C69FB99");

                    b.Navigation("Serie");
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Acteur", b =>
                {
                    b.Navigation("Personnages");
                });

            modelBuilder.Entity("SerieDLL_EF.Models.Serie", b =>
                {
                    b.Navigation("Personnages");

                    b.Navigation("Saisons");
                });
#pragma warning restore 612, 618
        }
    }
}
