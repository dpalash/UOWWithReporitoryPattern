namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupCorrection")]
    public partial class NaviTabBackupCorrection
    {
        public int Id { get; set; }

        public int? CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        public int PublicaitonDocumentId { get; set; }

        public int CorrectionDocStartPage { get; set; }

        public int CorrectionDocEndPage { get; set; }

        public int OriginalDocStartPage { get; set; }

        public int OriginalDocEndPage { get; set; }

        public int Volume { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
