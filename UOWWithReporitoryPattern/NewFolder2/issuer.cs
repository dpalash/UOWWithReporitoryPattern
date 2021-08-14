namespace UOWWithReporitoryPattern.NewFolder2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class issuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public issuer()
        {
            EncCells = new HashSet<EncCell>();
            EncProducts = new HashSet<EncProduct>();
            IssuersEncOrderHeaders = new HashSet<IssuersEncOrderHeader>();
        }

        [Key]
        [Column("_Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int C_Id { get; set; }

        [Column("_Issuer")]
        [Required]
        [StringLength(50)]
        public string C_Issuer { get; set; }

        [Column("_IssuerShortName")]
        [StringLength(10)]
        public string C_IssuerShortName { get; set; }

        [Column("_Active")]
        public bool C_Active { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCell> EncCells { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncProduct> EncProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersEncOrderHeader> IssuersEncOrderHeaders { get; set; }
    }
}
