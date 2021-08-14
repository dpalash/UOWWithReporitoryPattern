namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderHeader()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime UtcCreatedAt { get; set; }

        [StringLength(50)]
        public string CustomerServiceTicketId { get; set; }

        [StringLength(100)]
        public string OrderedByEmail { get; set; }

        [StringLength(255)]
        public string InvoiceNumber { get; set; }

        [StringLength(255)]
        public string InvoiceRef { get; set; }

        [StringLength(255)]
        public string InvoiceComment { get; set; }

        [StringLength(255)]
        public string InvoiceBy { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public byte OrderStatusId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        public virtual OrderStatu OrderStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
