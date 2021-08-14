namespace UOWWithReporitoryPattern.Notifications
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GeneralEntityManagementDbContext : DbContext
    {
        public GeneralEntityManagementDbContext()
            : base("name=GeneralEntityManagementDbContext")
        {
        }

        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<NotificationMessage> NotificationMessages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
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
                .HasMany(e => e.NotificationMessages)
                .WithOptional(e => e.customer)
                .HasForeignKey(e => e.CustomerId);
        }
    }
}
