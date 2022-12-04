using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkApp.Models;

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

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Saison> Saisons { get; set; }

    public virtual DbSet<Serie> Series { get; set; }

    public virtual DbSet<UserApp> UserApps { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Properties.Settings.Default.Cnx);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acteur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__acteur__3213E83F012BD232");
        });

        modelBuilder.Entity<Episode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__episode__3213E83F07132552");
        });

        modelBuilder.Entity<Personnage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__personna__3213E83F9D3A7249");

            entity.HasOne(d => d.Acteur).WithMany(p => p.Personnages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personnag__acteu__38996AB5");

            entity.HasOne(d => d.Serie).WithMany(p => p.Personnages)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__personnag__serie__398D8EEE");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__roles__3213E83FFE5FD017");
        });

        modelBuilder.Entity<Saison>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__saison__3213E83FAFFCF90F");

            entity.HasOne(d => d.Serie).WithMany(p => p.Saisons)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__saison__serie_id__3C69FB99");
        });

        modelBuilder.Entity<Serie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__serie__3213E83F1A62E8C0");
        });

        modelBuilder.Entity<UserApp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userApp__3213E83F7BE5A89E");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userRole__3213E83FAF269EA4");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__userRoles__role___52593CB8");

            entity.HasOne(d => d.UserApp).WithMany(p => p.UserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__userRoles__userA__5165187F");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
