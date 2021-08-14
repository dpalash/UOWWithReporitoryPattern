namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("customer")]
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            activesubscriptions = new HashSet<activesubscription>();
            CustomerEcdis = new HashSet<CustomerEcdi>();
            CustomerPermitsExtraLines = new HashSet<CustomerPermitsExtraLine>();
            CustomerPermitsPriorToPays = new HashSet<CustomerPermitsPriorToPay>();
            CustomersPositionProviders = new HashSet<CustomersPositionProvider>();
            Trackings = new HashSet<Tracking>();
            VesselPositions = new HashSet<VesselPosition>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int visma_id { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime added { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime expires { get; set; }

        [StringLength(10)]
        public string Port { get; set; }

        public int? added_year { get; set; }

        public int? added_week { get; set; }

        [Column("_neptunecode")]
        public int? C_neptunecode { get; set; }

        [StringLength(128)]
        public string authcode { get; set; }

        [StringLength(15)]
        public string version { get; set; }

        public int encid { get; set; }

        public int? imo { get; set; }

        [StringLength(50)]
        public string ukhoSapNo { get; set; }

        public bool AllowedToOrder { get; set; }

        public bool? CreditOk { get; set; }

        public int? ukhoLicenseId { get; set; }

        public int? VesselCompanyId { get; set; }

        public int? VesselCategoryId { get; set; }

        [StringLength(2)]
        public string CountryCode { get; set; }

        public DateTime ChangedAt { get; set; }

        public double? maxSpeed { get; set; }

        [Column(TypeName = "ntext")]
        public string OrderInfoEmailAddresses { get; set; }

        [StringLength(15)]
        public string NaviTabVersion { get; set; }

        public int? NaviPlannerVersion { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activesubscription> activesubscriptions { get; set; }

        public virtual Country Country { get; set; }

        public virtual VesselCategory VesselCategory { get; set; }

        public virtual VesselCompany VesselCompany { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEcdi> CustomerEcdis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsPriorToPay> CustomerPermitsPriorToPays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersPositionProvider> CustomersPositionProviders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Trackings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselPosition> VesselPositions { get; set; }
    }
}
