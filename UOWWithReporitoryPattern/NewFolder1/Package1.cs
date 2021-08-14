namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Packages")]
    public partial class Package1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package1()
        {
            PackageOpens = new HashSet<PackageOpen>();
        }

        [Key]
        public int PackageID { get; set; }

        public int SessionID { get; set; }

        public long Size { get; set; }

        public long SizeSaved { get; set; }

        public int FileCount { get; set; }

        public int NtmCount { get; set; }

        public int OptionalFilesCount { get; set; }

        public int CopiedCount { get; set; }

        public int CreatedCount { get; set; }

        public int ZippedCount { get; set; }

        public DateTime CreationTime { get; set; }

        [Required]
        [StringLength(50)]
        public string PackageKey { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Arguments { get; set; }

        [Column(TypeName = "xml")]
        public string PackageInfo { get; set; }

        public bool IsError { get; set; }

        public bool IsTransferred { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageOpen> PackageOpens { get; set; }

        public virtual Session1 Session { get; set; }
    }
}
