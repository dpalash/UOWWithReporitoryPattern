namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdpItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdpItem()
        {
            AdpSubscriptions = new HashSet<AdpSubscription>();
        }

        public int Id { get; set; }

        public int AdpProductId { get; set; }

        public int AdpCoverageAreaId { get; set; }

        [StringLength(50)]
        public string NauProdId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual AdpCoverageArea AdpCoverageArea { get; set; }

        public virtual AdpProduct AdpProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdpSubscription> AdpSubscriptions { get; set; }
    }
}
