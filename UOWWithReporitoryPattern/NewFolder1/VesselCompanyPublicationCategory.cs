namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselCompanyPublicationCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesselCompanyPublicationCategory()
        {
            VesselCompanyFiles = new HashSet<VesselCompanyFile>();
        }

        [Key]
        public int CategoryId { get; set; }

        [StringLength(200)]
        public string CategoryName { get; set; }

        public int GroupId { get; set; }

        [StringLength(200)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselCompanyFile> VesselCompanyFiles { get; set; }
    }
}
