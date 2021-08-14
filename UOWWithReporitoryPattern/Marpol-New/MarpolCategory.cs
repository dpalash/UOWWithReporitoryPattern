namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MarpolCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarpolCategory()
        {
            MarpolRegionsInCategories = new HashSet<MarpolRegionsInCategory>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryFriendlyName { get; set; }

        public DateTime? AddedUtcDate { get; set; }

        public DateTime? RemovedUtcDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarpolRegionsInCategory> MarpolRegionsInCategories { get; set; }
    }
}
