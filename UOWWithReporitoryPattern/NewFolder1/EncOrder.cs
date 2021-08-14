namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncOrder()
        {
            EncCellCustomerPermits = new HashSet<EncCellCustomerPermit>();
        }

        public int Id { get; set; }

        public int EncOrderTypeId { get; set; }

        public int IssuersEncOrderHeaderId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpiryUtcDate { get; set; }

        public decimal? Price { get; set; }

        public int EncOrderStatusId { get; set; }

        public int EncProductId { get; set; }

        public bool IsPaysPlus { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }

        public virtual EncOrderStatu EncOrderStatu { get; set; }

        public virtual EncOrderType EncOrderType { get; set; }

        public virtual EncProduct EncProduct { get; set; }

        public virtual IssuersEncOrderHeader IssuersEncOrderHeader { get; set; }
    }
}
