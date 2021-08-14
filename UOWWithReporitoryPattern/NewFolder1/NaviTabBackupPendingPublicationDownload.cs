namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupPendingPublicationDownload")]
    public partial class NaviTabBackupPendingPublicationDownload
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        public int? PendingDownloadId { get; set; }

        public int? PublicationId { get; set; }

        [StringLength(50)]
        public string PublicationNauProdId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
