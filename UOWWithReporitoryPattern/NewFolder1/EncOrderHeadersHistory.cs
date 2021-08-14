namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncOrderHeadersHistory")]
    public partial class EncOrderHeadersHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime UtcAuditDate { get; set; }

        public int CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerServiceTicketId { get; set; }

        [StringLength(100)]
        public string OrderedByEmail { get; set; }

        public DateTime UtcCreatedAt { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
