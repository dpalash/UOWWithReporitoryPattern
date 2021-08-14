namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesselCategory()
        {
            customers = new HashSet<customer>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string VismaDescription { get; set; }

        [StringLength(10)]
        public string PrimarCategoryId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<customer> customers { get; set; }

        public virtual PrimarVesselCategory PrimarVesselCategory { get; set; }
    }
}
