namespace UOWWithReporitoryPattern.ModelEntiry
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class UOWDBContext : DbContext
    {
        public UOWDBContext() : base("name=UOWDBContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroups { get; set; }
        public virtual DbSet<CustomerGroupVsCustomer> CustomerGroupVsCustomers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerGroup>()
                .HasMany(e => e.CustomerGroupVsCustomers)
                .WithOptional(e => e.CustomerGroup)
                .HasForeignKey(e => e.CustomerGroupId);
        }
    }
}
