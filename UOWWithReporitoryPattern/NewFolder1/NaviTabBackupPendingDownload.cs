namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupPendingDownload")]
    public partial class NaviTabBackupPendingDownload
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        [StringLength(50)]
        public string SessionKey { get; set; }

        [StringLength(50)]
        public string PackageKey { get; set; }

        [StringLength(50)]
        public string ServerHost { get; set; }

        public int? ServerPort { get; set; }

        public int? NumberOfFilesDownloaded { get; set; }

        public long? DownloadSize { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? DownloadDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
