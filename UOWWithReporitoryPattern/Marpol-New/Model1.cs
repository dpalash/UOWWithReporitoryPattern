namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model16")
        {
        }

        public virtual DbSet<MarpolAnnex> MarpolAnnexes { get; set; }
        public virtual DbSet<MarpolCategory> MarpolCategories { get; set; }
        public virtual DbSet<MarpolFileInfo> MarpolFileInfos { get; set; }
        public virtual DbSet<MarpolRegion> MarpolRegions { get; set; }
        public virtual DbSet<MarpolRegionsInAnnex> MarpolRegionsInAnnexes { get; set; }
        public virtual DbSet<MarpolRegionsInCategory> MarpolRegionsInCategories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarpolAnnex>()
                .HasMany(e => e.MarpolRegionsInAnnexes)
                .WithRequired(e => e.MarpolAnnex)
                .HasForeignKey(e => e.AnnexId);

            modelBuilder.Entity<MarpolCategory>()
                .HasMany(e => e.MarpolRegionsInCategories)
                .WithRequired(e => e.MarpolCategory)
                .HasForeignKey(e => e.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarpolFileInfo>()
                .Property(e => e.Discriminator)
                .IsFixedLength();

            modelBuilder.Entity<MarpolRegion>()
                .HasMany(e => e.MarpolFileInfos)
                .WithRequired(e => e.MarpolRegion)
                .HasForeignKey(e => e.RegionId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MarpolRegion>()
                .HasMany(e => e.MarpolRegionsInAnnexes)
                .WithRequired(e => e.MarpolRegion)
                .HasForeignKey(e => e.RegionId);

            modelBuilder.Entity<MarpolRegion>()
                .HasMany(e => e.MarpolRegionsInCategories)
                .WithRequired(e => e.MarpolRegion)
                .HasForeignKey(e => e.RegionId)
                .WillCascadeOnDelete(false);
        }
    }
}
