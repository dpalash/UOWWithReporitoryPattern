namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupCustomerInfo")]
    public partial class NaviTabBackupCustomerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NaviTabBackupCustomerInfo()
        {
            NaviTabBackupBackgroundImages = new HashSet<NaviTabBackupBackgroundImage>();
            NaviTabBackupCorrections = new HashSet<NaviTabBackupCorrection>();
            NaviTabBackupEReaderUsers = new HashSet<NaviTabBackupEReaderUser>();
            NaviTabBackupNaviTabInformations = new HashSet<NaviTabBackupNaviTabInformation>();
            NaviTabBackupPdfAttachments = new HashSet<NaviTabBackupPdfAttachment>();
            NaviTabBackupPendingDownloads = new HashSet<NaviTabBackupPendingDownload>();
            NaviTabBackupPendingPublicationDownloads = new HashSet<NaviTabBackupPendingPublicationDownload>();
            NaviTabBackupPublicaitonCatalogInfoes = new HashSet<NaviTabBackupPublicaitonCatalogInfo>();
            NaviTabBackupPublicationDocuments = new HashSet<NaviTabBackupPublicationDocument>();
            NaviTabBackupSearchSuggestions = new HashSet<NaviTabBackupSearchSuggestion>();
            NaviTabBackupServerInformations = new HashSet<NaviTabBackupServerInformation>();
        }

        public int ID { get; set; }

        public int CustomerID { get; set; }

        public int DeviceNumber { get; set; }

        public DateTime BackupTakenDate { get; set; }

        [StringLength(50)]
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
