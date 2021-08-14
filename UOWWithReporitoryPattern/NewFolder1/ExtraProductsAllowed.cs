namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExtraProductsAllowed")]
    public partial class ExtraProductsAllowed
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExtraProductsAllowed()
        {
            CustomerPermitsExtraLines = new HashSet<CustomerPermitsExtraLine>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(8)]
        public string ProductName { get; set; }

        public int IssuerId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }

        public virtual issuer issuer { get; set; }
    }
}
