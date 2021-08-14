namespace UOWWithReporitoryPattern.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IssuersEncOrderHeadersHistory")]
    public partial class IssuersEncOrderHeadersHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime UtcAuditDate { get; set; }

        public int EncOrderHeaderId { get; set; }

        public int IssuerId { get; set; }

        [StringLength(30)]
        public string OrderId { get; set; }

        public int IssuersEncOrderHeaderStatusId { get; set; }

        public DateTime? CanPlaceOrderUtcDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
