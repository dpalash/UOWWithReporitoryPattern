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
    
    public partial class NaviTabBackupCustomerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaviTabBackupCustomerInfo()
        {
            this.NaviTabBackupBackgroundImages = new HashSet<NaviTabBackupBackgroundImage>();
            this.NaviTabBackupCorrections = new HashSet<NaviTabBackupCorrection>();
            this.NaviTabBackupEReaderUsers = new HashSet<NaviTabBackupEReaderUser>();
            this.NaviTabBackupNaviTabInformations = new HashSet<NaviTabBackupNaviTabInformation>();
            this.NaviTabBackupPdfAttachments = new HashSet<NaviTabBackupPdfAttachment>();
            this.NaviTabBackupPendingDownloads = new HashSet<NaviTabBackupPendingDownload>();
            this.NaviTabBackupPendingPublicationDownloads = new HashSet<NaviTabBackupPendingPublicationDownload>();
            this.NaviTabBackupPublicaitonCatalogInfoes = new HashSet<NaviTabBackupPublicaitonCatalogInfo>();
            this.NaviTabBackupPublicationDocuments = new HashSet<NaviTabBackupPublicationDocument>();
            this.NaviTabBackupSearchSuggestions = new HashSet<NaviTabBackupSearchSuggestion>();
            this.NaviTabBackupServerInformations = new HashSet<NaviTabBackupServerInformation>();
        }
    
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int DeviceNumber { get; set; }
        public System.DateTime BackupTakenDate { get; set; }
        public string Discriminator { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupBackgroundImage> NaviTabBackupBackgroundImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupCorrection> NaviTabBackupCorrections { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupEReaderUser> NaviTabBackupEReaderUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupNaviTabInformation> NaviTabBackupNaviTabInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupPdfAttachment> NaviTabBackupPdfAttachments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupPendingDownload> NaviTabBackupPendingDownloads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupPendingPublicationDownload> NaviTabBackupPendingPublicationDownloads { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupPublicaitonCatalogInfo> NaviTabBackupPublicaitonCatalogInfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupPublicationDocument> NaviTabBackupPublicationDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupSearchSuggestion> NaviTabBackupSearchSuggestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NaviTabBackupServerInformation> NaviTabBackupServerInformations { get; set; }
    }
}