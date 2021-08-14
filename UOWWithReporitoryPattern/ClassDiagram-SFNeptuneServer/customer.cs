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
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.activesubscriptions = new HashSet<activesubscription>();
            this.CustomerEcdis = new HashSet<CustomerEcdi>();
            this.Voyages = new HashSet<Voyage>();
            this.CustomerPermitsExtraLines = new HashSet<CustomerPermitsExtraLine>();
            this.CustomerPermitsPriorToPays = new HashSet<CustomerPermitsPriorToPay>();
            this.CustomersPositionProviders = new HashSet<CustomersPositionProvider>();
            this.EncCellCustomerPaysAreas = new HashSet<EncCellCustomerPaysArea>();
            this.EncCellCustomerPermits = new HashSet<EncCellCustomerPermit>();
            this.EncOrderHeaders = new HashSet<EncOrderHeader>();
            this.FrequentlyUsedEncProducts = new HashSet<FrequentlyUsedEncProduct>();
            this.IssuersCustomerInfoes = new HashSet<IssuersCustomerInfo>();
            this.NotificationMessages = new HashSet<NotificationMessage>();
            this.OrderHeaders = new HashSet<OrderHeader>();
            this.PreorderedPublicationInformations = new HashSet<PreorderedPublicationInformation>();
            this.SharedRouteFileInfos = new HashSet<SharedRouteFileInfo>();
            this.Trackings = new HashSet<Tracking>();
            this.ValueAddedSubscriptions = new HashSet<ValueAddedSubscription>();
            this.VesselCompanyFileAccesses = new HashSet<VesselCompanyFileAccess>();
            this.VesselPositions = new HashSet<VesselPosition>();
            this.VesselPositions_Dummy = new HashSet<VesselPositions_Dummy>();
        }
    
        public int id { get; set; }
        public int visma_id { get; set; }
        public string name { get; set; }
        public System.DateTime added { get; set; }
        public System.DateTime expires { get; set; }
        public string Port { get; set; }
        public Nullable<int> added_year { get; set; }
        public Nullable<int> added_week { get; set; }
        public Nullable<int> C_neptunecode { get; set; }
        public string authcode { get; set; }
        public string version { get; set; }
        public int encid { get; set; }
        public Nullable<int> imo { get; set; }
        public string ukhoSapNo { get; set; }
        public bool AllowedToOrder { get; set; }
        public Nullable<bool> CreditOk { get; set; }
        public Nullable<int> ukhoLicenseId { get; set; }
        public Nullable<int> VesselCompanyId { get; set; }
        public Nullable<int> VesselCategoryId { get; set; }
        public string CountryCode { get; set; }
        public System.DateTime ChangedAt { get; set; }
        public Nullable<double> maxSpeed { get; set; }
        public string OrderInfoEmailAddresses { get; set; }
        public string NaviTabVersion { get; set; }
        public Nullable<int> NaviPlannerVersion { get; set; }
        public string Discriminator { get; set; }
        public string NaviLoggerVersion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activesubscription> activesubscriptions { get; set; }
        public virtual Country Country { get; set; }
        public virtual VesselCategory VesselCategory { get; set; }
        public virtual VesselCompany VesselCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerEcdi> CustomerEcdis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Voyage> Voyages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsExtraLine> CustomerPermitsExtraLines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPermitsPriorToPay> CustomerPermitsPriorToPays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomersPositionProvider> CustomersPositionProviders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPaysArea> EncCellCustomerPaysAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncOrderHeader> EncOrderHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FrequentlyUsedEncProduct> FrequentlyUsedEncProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssuersCustomerInfo> IssuersCustomerInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationMessage> NotificationMessages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderHeader> OrderHeaders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreorderedPublicationInformation> PreorderedPublicationInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SharedRouteFileInfo> SharedRouteFileInfos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Trackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValueAddedSubscription> ValueAddedSubscriptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselCompanyFileAccess> VesselCompanyFileAccesses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselPosition> VesselPositions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselPositions_Dummy> VesselPositions_Dummy { get; set; }
    }
}