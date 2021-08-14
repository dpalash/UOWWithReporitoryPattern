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
    
    public partial class Voyage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voyage()
        {
            this.RequiredEncsForVoyages = new HashSet<RequiredEncsForVoyage>();
            this.VoyageDocuments = new HashSet<VoyageDocument>();
            this.VoyageRoutes = new HashSet<VoyageRoute>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int IssuerId { get; set; }
        public Nullable<System.DateTime> ETA { get; set; }
        public Nullable<System.DateTime> ETD { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public string ViaPortNames { get; set; }
        public Nullable<int> RouteStatus { get; set; }
        public Nullable<int> ProductStatus { get; set; }
        public Nullable<int> UpdateStatus { get; set; }
        public string RtzFileName { get; set; }
        public string RtzFilePath { get; set; }
        public Nullable<System.DateTime> UploadedDate { get; set; }
        public Nullable<System.DateTime> ChangedDate { get; set; }
        public string RouteName { get; set; }
        public Nullable<int> NaviPlannerUserId { get; set; }
        public string NaviPlannerUserName { get; set; }
        public string SourceName { get; set; }
        public string Discriminator { get; set; }
    
        public virtual customer customer { get; set; }
        public virtual issuer issuer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredEncsForVoyage> RequiredEncsForVoyages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoyageDocument> VoyageDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VoyageRoute> VoyageRoutes { get; set; }
    }
}