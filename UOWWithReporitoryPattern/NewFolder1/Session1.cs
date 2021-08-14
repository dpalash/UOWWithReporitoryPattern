namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sessions")]
    public partial class Session1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Session1()
        {
            PackageOpens = new HashSet<PackageOpen>();
            Packages = new HashSet<Package1>();
            Transfers = new HashSet<Transfer>();
        }

        [Key]
        public int SessionID { get; set; }

        public int ServerID { get; set; }

        public int CustomerID { get; set; }

        public bool IsMail { get; set; }

        [StringLength(128)]
        public string IP { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? EndTime { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageOpen> PackageOpens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Package1> Packages { get; set; }

        public virtual Server Server { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transfer> Transfers { get; set; }
    }
}
