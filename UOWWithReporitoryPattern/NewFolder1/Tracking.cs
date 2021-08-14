namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tracking")]
    public partial class Tracking
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public DbGeometry Track { get; set; }

        [StringLength(1024)]
        public string Ordered { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TimestampUtc { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }
    }
}
