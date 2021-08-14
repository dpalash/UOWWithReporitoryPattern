//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UOWWithReporitoryPattern.ClassDiagram_SFNeptuneServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class issuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public issuer()
        {
            this.activesubscriptions = new HashSet<activesubscription>();
            this.EncCells = new HashSet<EncCell>();
            this.EncFileInfos = new HashSet<EncFileInfo>();
            this.EncProducts = new HashSet<EncProduct>();
            this.ExtraProductsAlloweds = new HashSet<ExtraProductsAllowed>();
            this.Voyages = new HashSet<Voyage>();
            this.IssuersAvailableToCustomers = new HashSet<IssuersAvailableToCustomer>();
            this.IssuersCustomerInfoes = new HashSet<IssuersCustomerInfo>();
            this.IssuersEncOrderHeaders = new HashSet<IssuersEncOrderHeader>();
            this.IssuersVesselCompanyInfoes = new HashSet<IssuersVesselCompanyInfo>();
            this.OrderLines = new HashSet<OrderLine>();
            this.PublicationCorrectionDocuments = new HashSet<PublicationCorrectionDocument>();
            this.SharedRouteFileInfos = new HashSet<SharedRouteFileInfo>();
        }
    
        public int C_Id { get; set; }
        public string C_Issuer { get; set; }
        public string C_IssuerShortName { get; set; }
        public bool C_Active { get; set; }
        public string Discriminator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activesubscription> activesubscriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCell> EncCells { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncFileInfo> EncFileInfos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncProduct> EncProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExtraProductsAllowed> ExtraProductsAlloweds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voyage> Voyages { get; set; }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharedRouteFileInfo> SharedRouteFileInfos { get; set; }
    }
}