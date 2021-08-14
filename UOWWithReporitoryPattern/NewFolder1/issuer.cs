namespace UOWWithReporitoryPattern.NewFolder1
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
            activesubscriptions = new HashSet<activesubscription>();
            EncCells = new HashSet<EncCell>();
            EncProducts = new HashSet<EncProduct>();
            ExtraProductsAlloweds = new HashSet<ExtraProductsAllowed>();
            IssuersAvailableToCustomers = new HashSet<IssuersAvailableToCustomer>();
            IssuersCustomerInfoes = new HashSet<IssuersCustomerInfo>();
            IssuersEncOrderHeaders = new HashSet<IssuersEncOrderHeader>();
            IssuersVesselCompanyInfoes = new HashSet<IssuersVesselCompanyInfo>();
            OrderLines = new HashSet<OrderLine>();
            PublicationCorrectionDocuments = new HashSet<PublicationCorrectionDocument>();
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
        public virtual ICollection<activesubscription> activesubscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCell> EncCells { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncProduct> EncProducts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraProductsAllowed> ExtraProductsAlloweds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersAvailableToCustomer> IssuersAvailableToCustomers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersCustomerInfo> IssuersCustomerInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersEncOrderHeader> IssuersEncOrderHeaders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersVesselCompanyInfo> IssuersVesselCompanyInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderLine> OrderLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PublicationCorrectionDocument> PublicationCorrectionDocuments { get; set; }
    }
}
