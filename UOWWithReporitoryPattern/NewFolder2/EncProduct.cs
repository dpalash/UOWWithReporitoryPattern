namespace UOWWithReporitoryPattern.NewFolder2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncProduct()
        {
            EncCellsInEncProducts = new HashSet<EncCellsInEncProduct>();
            EncOrders = new HashSet<EncOrder>();
            EncProductPrices = new HashSet<EncProductPrice>();
        }

        public int Id { get; set; }

        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(15)]
        public string ValidLicensePeriod { get; set; }

        public bool IsForSale { get; set; }

        public int EncProductTypeId { get; set; }

        public int IssuerId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellsInEncProduct> EncCellsInEncProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncOrder> EncOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncProductPrice> EncProductPrices { get; set; }

        public virtual EncProductType EncProductType { get; set; }

        public virtual issuer issuer { get; set; }
    }
}
