namespace UOWWithReporitoryPattern.Marpol
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarpolData")]
    public partial class MarpolData
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(50)]
        public string CategoryFriendlyName { get; set; }

        [StringLength(50)]
        public string RegionName { get; set; }

        [StringLength(100)]
        public string RegionFriendlyName { get; set; }

        [StringLength(100)]
        public string RegionDisplayName { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string FileNameWithBlobPath { get; set; }

        public DateTime AddedUtcDate { get; set; }

        public DateTime? LastDownloadUtcDate { get; set; }

        public DateTime? RemovedUtcDate { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
