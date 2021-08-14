namespace UOWWithReporitoryPattern.NewFolder2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IssuersEncOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IssuersEncOrderHeader()
        {
            EncOrders = new HashSet<EncOrder>();
        }

        public int Id { get; set; }

        public int EncOrderHeaderId { get; set; }

        public int IssuerId { get; set; }

        [StringLength(30)]
        public string OrderId { get; set; }

        public int IssuersEncOrderHeaderStatusId { get; set; }

        public DateTime? CanPlaceOrderUtcDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncOrderHeader EncOrderHeader { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncOrder> EncOrders { get; set; }

        public virtual issuer issuer { get; set; }

        public virtual IssuersEncOrderHeaderStatu IssuersEncOrderHeaderStatu { get; set; }
    }
}
