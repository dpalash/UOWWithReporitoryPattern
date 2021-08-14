namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncProductPrice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EncProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EncOrderTypeId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ValidFromUtcDate { get; set; }

        public DateTime? ValidToUtcDateTo { get; set; }

        public decimal Price { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncOrderType EncOrderType { get; set; }

        public virtual EncProduct EncProduct { get; set; }
    }
}
