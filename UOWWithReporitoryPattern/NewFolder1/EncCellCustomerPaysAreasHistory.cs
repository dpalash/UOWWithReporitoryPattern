namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncCellCustomerPaysAreasHistory")]
    public partial class EncCellCustomerPaysAreasHistory
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
        public DateTime UtcAuditDate { get; set; }

        public int PaysAreaStatusId { get; set; }

        [StringLength(50)]
        public string CustomerServiceTicketId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
