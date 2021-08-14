namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MarpolAnnex
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarpolAnnex()
        {
            MarpolRegionsInAnnexes = new HashSet<MarpolRegionsInAnnex>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string AnnexName { get; set; }

        [StringLength(50)]
        public string AnnexFriendlyName { get; set; }

        public DateTime? AddedUtcDate { get; set; }

        public DateTime? RemovedUtcDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarpolRegionsInAnnex> MarpolRegionsInAnnexes { get; set; }
    }
}
