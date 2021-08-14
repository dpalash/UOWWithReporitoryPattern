namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupPublicationDocument")]
    public partial class NaviTabBackupPublicationDocument
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        [StringLength(50)]
        public string NauProdId { get; set; }

        [StringLength(50)]
        public string ProdId { get; set; }

        public int? PublicationId { get; set; }

        public int? MaxPrintCount { get; set; }

        public int? MaxPercentagePrintAllowed { get; set; }

        [StringLength(50)]
        public string FileName { get; set; }

        public int? ParentDocId { get; set; }

        public DateTime? PublicationDownloadDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
