namespace UOWWithReporitoryPattern.Voyage
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class VoyageContext : DbContext
    {
        public VoyageContext()
            : base("name=VoyageContext1")
        {
        }

        public virtual DbSet<EncCell> EncCells { get; set; }
        public virtual DbSet<issuer> issuers { get; set; }
        public virtual DbSet<MissingEncsForVoyage> MissingEncsForVoyages { get; set; }
        public virtual DbSet<OutdatedEncsForVoyage> OutdatedEncsForVoyages { get; set; }
        public virtual DbSet<RequiredEncsForVoyage> RequiredEncsForVoyages { get; set; }
        public virtual DbSet<VoyageRoute> VoyageRoutes { get; set; }
        public virtual DbSet<Voyage> Voyages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncCell>()
                .Property(e => e.CellName)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundarySLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryWLon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryNLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.BoundaryELon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.PolygonPoints)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.GeometryData)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.MissingEncsForVoyages)
                .WithOptional(e => e.EncCell)
                .HasForeignKey(e => e.EncId);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.OutdatedEncsForVoyages)
                .WithOptional(e => e.EncCell)
                .HasForeignKey(e => e.EncId);

            modelBuilder.Entity<issuer>()
                .Property(e => e.C_IssuerShortName)
                .IsUnicode(false);

            modelBuilder.Entity<issuer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.EncCells)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.Voyages)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MissingEncsForVoyage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<OutdatedEncsForVoyage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<RequiredEncsForVoyage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VoyageRoute>()
                .Property(e => e.Lat)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VoyageRoute>()
                .Property(e => e.Lon)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VoyageRoute>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Voyage>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Voyage>()
                .HasMany(e => e.MissingEncsForVoyages)
                .WithRequired(e => e.Voyage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voyage>()
                .HasMany(e => e.OutdatedEncsForVoyages)
                .WithRequired(e => e.Voyage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voyage>()
                .HasMany(e => e.RequiredEncsForVoyages)
                .WithRequired(e => e.Voyage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voyage>()
                .HasMany(e => e.VoyageRoutes)
                .WithRequired(e => e.Voyage)
                .WillCascadeOnDelete(false);
        }
    }
}
