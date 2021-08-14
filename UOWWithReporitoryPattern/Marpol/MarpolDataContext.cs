namespace UOWWithReporitoryPattern.Marpol
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarpolDataContext : DbContext
    {
        public MarpolDataContext()
            : base("name=MarpolDataContext")
        {
        }

        public virtual DbSet<MarpolData> MarpolDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarpolData>()
                .Property(e => e.Discriminator)
                .IsUnicode(false);
        }
    }
}
