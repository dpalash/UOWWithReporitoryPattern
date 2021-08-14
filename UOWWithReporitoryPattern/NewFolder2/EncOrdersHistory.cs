namespace UOWWithReporitoryPattern.NewFolder2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncOrdersHistory")]
    public partial class EncOrdersHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime UtcAuditDate { get; set; }

        public int EncOrderTypeId { get; set; }

        public int IssuersEncOrderHeaderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryUtcDate { get; set; }

        public decimal? Price { get; set; }

        public int EncOrderStatusId { get; set; }

        public int EncProductId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
