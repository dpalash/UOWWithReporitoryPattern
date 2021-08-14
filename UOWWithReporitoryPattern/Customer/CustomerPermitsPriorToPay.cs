namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CustomerPermitsPriorToPay
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

        [Column(TypeName = "date")]
        public DateTime? ExpiryUtcDate { get; set; }

        [StringLength(100)]
        public string PermitString { get; set; }

        public int? EncOrderId { get; set; }

        public DateTime? PermitDownloadedUtcDate { get; set; }

        public int PermitStatusId { get; set; }

        public virtual customer customer { get; set; }
    }
}
