namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupNaviTabInformation")]
    public partial class NaviTabBackupNaviTabInformation
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        public DateTime? DateInstalled { get; set; }

        public int? VersionNo { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
