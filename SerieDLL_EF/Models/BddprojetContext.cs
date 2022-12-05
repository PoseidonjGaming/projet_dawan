using Microsoft.EntityFrameworkCore;

namespace projet_dawan.Models;

public partial class BddprojetContext : DbContext
{
    public BddprojetContext()
    {
    }

    public BddprojetContext(DbContextOptions<BddprojetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acteur> Acteurs { get; set; }

    public virtual DbSet<Episode> Episodes { get; set; }

    public virtual DbSet<Personnage> Personnages { get; set; }

    public virtual DbSet<Saison> Saisons { get; set; }

    public virtual DbSet<Serie> Series { get; set; }

    public virtual DbSet<UserApp> UserApps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=P3570-7D6Q;Initial Catalog=serie_list;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acteur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acteur__3213E83F012BD232");

            entity.ToTable("acteur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<Episode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__episode__3213E83F07132552");

            entity.ToTable("episode");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DatePremDiff)
                .HasColumnType("date")
                .HasColumnName("date_prem_diff");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Resume)
                .IsUnicode(false)
                .HasColumnName("resume");
            entity.Property(e => e.SaisonId).HasColumnName("saison_id");
        });

        modelBuilder.Entity<Personnage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personna__3213E83F9D3A7249");

            entity.ToTable("personnage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActeurId).HasColumnName("acteur_id");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.SerieId).HasColumnName("serie_id");

            entity.HasOne(d => d.Acteur).WithMany(p => p.Personnages)
                .HasForeignKey(d => d.ActeurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personnag__acteu__38996AB5");

            entity.HasOne(d => d.Serie).WithMany(p => p.Personnages)
                .HasForeignKey(d => d.SerieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personnag__serie__398D8EEE");
        });

        modelBuilder.Entity<Saison>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__saison__3213E83FAFFCF90F");

            entity.ToTable("saison");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NbEpisode).HasColumnName("nb_episode");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.SerieId).HasColumnName("serie_id");

            entity.HasOne(d => d.Serie).WithMany(p => p.Saisons)
                .HasForeignKey(d => d.SerieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__saison__serie_id__3C69FB99");
        });

        modelBuilder.Entity<Serie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__serie__3213E83F1A62E8C0");

            entity.ToTable("serie");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Affiche)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("affiche");
            entity.Property(e => e.DateDiff)
                .HasColumnType("date")
                .HasColumnName("date_diff");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Resume)
                .IsUnicode(false)
                .HasColumnName("resume");
           
            entity.Property(e => e.UrlBa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("url_ba");
        });

        modelBuilder.Entity<UserApp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userApp__3213E83F7BE5A89E");

            entity.ToTable("userApp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Roles)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
