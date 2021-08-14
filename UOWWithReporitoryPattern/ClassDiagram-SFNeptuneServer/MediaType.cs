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
    
    public partial class MediaType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MediaType()
        {
            this.FagbokforlagetCatalogs = new HashSet<FagbokforlagetCatalog>();
            this.ImoCatalogs = new HashSet<ImoCatalog>();
            this.ImrayCatalogs = new HashSet<ImrayCatalog>();
            this.LogBookCatalogs = new HashSet<LogBookCatalog>();
            this.NorwegianCatalogs = new HashSet<NorwegianCatalog>();
            this.ShippingGuidesCatalogs = new HashSet<ShippingGuidesCatalog>();
            this.USCatalogs = new HashSet<USCatalog>();
            this.VesselCompanyFiles = new HashSet<VesselCompanyFile>();
        }
    
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Discriminator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FagbokforlagetCatalog> FagbokforlagetCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImoCatalog> ImoCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImrayCatalog> ImrayCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogBookCatalog> LogBookCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NorwegianCatalog> NorwegianCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingGuidesCatalog> ShippingGuidesCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USCatalog> USCatalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselCompanyFile> VesselCompanyFiles { get; set; }
    }
}
