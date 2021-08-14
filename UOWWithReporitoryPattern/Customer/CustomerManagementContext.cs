namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerManagementContext : DbContext
    {
        public CustomerManagementContext() : base("name=CustomerManagementContext")
        {
        }

        public virtual DbSet<activesubscription> activesubscriptions { get; set; }
        public virtual DbSet<activesubscriptions_backup> activesubscriptions_backup { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<CustomerEcdi> CustomerEcdis { get; set; }
        public virtual DbSet<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }
        public virtual DbSet<CustomerPermitsPriorToPay> CustomerPermitsPriorToPays { get; set; }
        public virtual DbSet<CustomersInmarsatProvider> CustomersInmarsatProviders { get; set; }
        public virtual DbSet<CustomersPositionProvider> CustomersPositionProviders { get; set; }
        public virtual DbSet<CustomVersion> CustomVersions { get; set; }
        public virtual DbSet<PositionProvider> PositionProviders { get; set; }
        public virtual DbSet<Tracking> Trackings { get; set; }
        public virtual DbSet<VesselCategory> VesselCategories { get; set; }
        public virtual DbSet<VesselCompany> VesselCompanies { get; set; }
        public virtual DbSet<VesselPosition> VesselPositions { get; set; }
        public virtual DbSet<activesubscriptions_new> activesubscriptions_new { get; set; }
        public virtual DbSet<CountriesAllowingPaysPlu> CountriesAllowingPaysPlus { get; set; }
        public virtual DbSet<CustomerDeviceInfo> CustomerDeviceInfoes { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<activesubscription>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<activesubscriptions_backup>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.PrimarCountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.VesselCompanies)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Port)
                .IsFixedLength();

            modelBuilder.Entity<customer>()
                .Property(e => e.authcode)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.NaviTabVersion)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.activesubscriptions)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.C_CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomerEcdis)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomerPermitsExtraLines)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomerPermitsPriorToPays)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.CustomersPositionProviders)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.Trackings)
                .WithRequired(e => e.customer)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.VesselPositions)
                .WithOptional(e => e.customer)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerEcdi>()
                .Property(e => e.UserPermit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CustomerEcdi>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPermitsExtraLine>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPermitsExtraLine>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerPermitsPriorToPay>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.DNID)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.MemberNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.TerminalId)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersInmarsatProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersPositionProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomersPositionProvider>()
                .HasMany(e => e.CustomersInmarsatProviders)
                .WithRequired(e => e.CustomersPositionProvider)
                .HasForeignKey(e => e.CustPosProvId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomVersion>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CustomVersion>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PositionProvider>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<PositionProvider>()
                .HasMany(e => e.CustomersPositionProviders)
                .WithRequired(e => e.PositionProvider)
                .HasForeignKey(e => e.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PositionProvider>()
                .HasMany(e => e.VesselPositions)
                .WithRequired(e => e.PositionProvider)
                .HasForeignKey(e => e.ProviderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tracking>()
                .Property(e => e.Ordered)
                .IsUnicode(false);

            modelBuilder.Entity<Tracking>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.VismaDescription)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.PrimarCategoryId)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCategory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompany>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VesselCompany>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<VesselPosition>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<activesubscriptions_new>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerDeviceInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerGroup>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerInfo>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);
        }
    }
}
