namespace UOWWithReporitoryPattern.NewFolder3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model14")
        {
        }

        public virtual DbSet<EncCellCustomerPaysArea> EncCellCustomerPaysAreas { get; set; }
        public virtual DbSet<EncCellCustomerPaysAreasHistory> EncCellCustomerPaysAreasHistories { get; set; }
        public virtual DbSet<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }
        public virtual DbSet<EncCellCustomerPermitsHistory> EncCellCustomerPermitsHistories { get; set; }
        public virtual DbSet<EncOrderHeader> EncOrderHeaders { get; set; }
        public virtual DbSet<EncOrderHeadersHistory> EncOrderHeadersHistories { get; set; }
        public virtual DbSet<EncOrder> EncOrders { get; set; }
        public virtual DbSet<EncOrdersHistory> EncOrdersHistories { get; set; }
        public virtual DbSet<EncOrderStatu> EncOrderStatus { get; set; }
        public virtual DbSet<EncOrderType> EncOrderTypes { get; set; }
        public virtual DbSet<IssuersEncOrderHeader> IssuersEncOrderHeaders { get; set; }
        public virtual DbSet<IssuersEncOrderHeadersHistory> IssuersEncOrderHeadersHistories { get; set; }
        public virtual DbSet<IssuersEncOrderHeaderStatu> IssuersEncOrderHeaderStatus { get; set; }

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
        }
    }
}
