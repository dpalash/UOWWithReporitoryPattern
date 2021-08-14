namespace UOWWithReporitoryPattern.NewFolder3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncCellCustomerPermitsHistory")]
    public partial class EncCellCustomerPermitsHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EncCellId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EcdisTypeId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UtcAuditDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryUtcDate { get; set; }

        [StringLength(100)]
        public string PermitString { get; set; }

        public int? EncOrderId { get; set; }

        public DateTime? PermitDownloadedUtcDate { get; set; }

        public int PermitStatusId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
