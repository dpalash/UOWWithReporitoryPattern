namespace UOWWithReporitoryPattern.NewFolder2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<EncCellCustomerPaysArea> EncCellCustomerPaysAreas { get; set; }
        public virtual DbSet<EncCellCustomerPaysAreasHistory> EncCellCustomerPaysAreasHistories { get; set; }
        public virtual DbSet<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }
        public virtual DbSet<EncCellCustomerPermitsHistory> EncCellCustomerPermitsHistories { get; set; }
        public virtual DbSet<EncCellReplacement> EncCellReplacements { get; set; }
        public virtual DbSet<EncCell> EncCells { get; set; }
        public virtual DbSet<EncCellsHistory> EncCellsHistories { get; set; }
        public virtual DbSet<EncCellsInEncProduct> EncCellsInEncProducts { get; set; }
        public virtual DbSet<EncOrderHeader> EncOrderHeaders { get; set; }
        public virtual DbSet<EncOrderHeadersHistory> EncOrderHeadersHistories { get; set; }
        public virtual DbSet<EncOrder> EncOrders { get; set; }
        public virtual DbSet<EncOrdersHistory> EncOrdersHistories { get; set; }
        public virtual DbSet<EncOrderStatu> EncOrderStatus { get; set; }
        public virtual DbSet<EncOrderType> EncOrderTypes { get; set; }
        public virtual DbSet<EncProductPrice> EncProductPrices { get; set; }
        public virtual DbSet<EncProduct> EncProducts { get; set; }
        public virtual DbSet<EncProductType> EncProductTypes { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<issuer> issuers { get; set; }
        public virtual DbSet<IssuersEncOrderHeader> IssuersEncOrderHeaders { get; set; }
        public virtual DbSet<IssuersEncOrderHeadersHistory> IssuersEncOrderHeadersHistories { get; set; }
        public virtual DbSet<IssuersEncOrderHeaderStatu> IssuersEncOrderHeaderStatus { get; set; }
        public virtual DbSet<CountriesAllowingPaysPlu> CountriesAllowingPaysPlus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncCellCustomerPaysArea>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysArea>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysAreasHistory>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPaysAreasHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermit>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermit>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermitsHistory>()
                .Property(e => e.PermitString)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellCustomerPermitsHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellReplacement>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

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
                .HasMany(e => e.EncCellCustomerPaysAreas)
                .WithRequired(e => e.EncCell)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellCustomerPermits)
                .WithRequired(e => e.EncCell)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellReplacements)
                .WithRequired(e => e.EncCell)
                .HasForeignKey(e => e.ReplacementCellId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncCell>()
                .HasMany(e => e.EncCellReplacements1)
                .WithRequired(e => e.EncCell1)
                .HasForeignKey(e => e.OriginalCellId);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.CellName)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundarySLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryWLon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryNLat)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.BoundaryELon)
                .HasPrecision(11, 8);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.PolygonPoints)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.GeometryData)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncCellsInEncProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.OrderedByEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceNumber)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceRef)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceComment)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.InvoiceBy)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeader>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.EncOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.CustomerServiceTicketId)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.OrderedByEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderHeadersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrder>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncOrder>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrdersHistory>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncOrdersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderStatu>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncOrderStatu)
                .HasForeignKey(e => e.EncOrderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncOrderType>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncOrderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncOrderType>()
                .HasMany(e => e.EncProductPrices)
                .WithRequired(e => e.EncOrderType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProductPrice>()
                .Property(e => e.Price)
                .HasPrecision(12, 2);

            modelBuilder.Entity<EncProductPrice>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.ValidLicensePeriod)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProduct>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.EncProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProduct>()
                .HasMany(e => e.EncProductPrices)
                .WithRequired(e => e.EncProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EncProductType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<EncProductType>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<EncProductType>()
                .HasMany(e => e.EncProducts)
                .WithRequired(e => e.EncProductType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.BaseCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.ForeignCurrency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Rate)
                .HasPrecision(18, 6);

            modelBuilder.Entity<ExchangeRate>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

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
                .HasMany(e => e.EncProducts)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<issuer>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.issuer)
                .HasForeignKey(e => e.IssuerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeader>()
                .HasMany(e => e.EncOrders)
                .WithRequired(e => e.IssuersEncOrderHeader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IssuersEncOrderHeadersHistory>()
                .Property(e => e.OrderId)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeadersHistory>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);

            modelBuilder.Entity<IssuersEncOrderHeaderStatu>()
                .HasMany(e => e.IssuersEncOrderHeaders)
                .WithRequired(e => e.IssuersEncOrderHeaderStatu)
                .HasForeignKey(e => e.IssuersEncOrderHeaderStatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.CountryCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CountriesAllowingPaysPlu>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);
        }
    }
}
