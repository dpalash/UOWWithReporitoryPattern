namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupServerInformation")]
    public partial class NaviTabBackupServerInformation
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        [StringLength(50)]
        public string ServerHost { get; set; }

        public int? ServerPort { get; set; }

        public string AuthKey { get; set; }

        [StringLength(50)]
        public string VesselName { get; set; }

        [StringLength(50)]
        public string CatalogPackageFolder { get; set; }

        [StringLength(50)]
        public string CustomerId { get; set; }

        [StringLength(50)]
        public string DeviceSerialNumber { get; set; }

        public int? DeviceNumber { get; set; }

        public string HardwareId { get; set; }

        public int? Timeout { get; set; }

        [StringLength(50)]
        public string RetryInterval { get; set; }

        public int? IsNaviTabAutoUpgradeOn { get; set; }

        public DateTime? NaviTabAutoUpgradeCheckDate { get; set; }

        public int? UnorderedSearchResultCount { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
