namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarpolFileInfos")]
    public partial class MarpolFileInfo
    {
        public int Id { get; set; }

        public int RegionId { get; set; }

        [StringLength(100)]
        public string FileName { get; set; }

        [StringLength(500)]
        public string FileNameWithBlobPath { get; set; }

        public DateTime? LastDownloadedUtcDate { get; set; }

        public DateTime? AddedUtcDate { get; set; }

        public DateTime? RemovedUtcDate { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        [Required]
        [StringLength(10)]
        public string Discriminator { get; set; }

        public virtual MarpolRegion MarpolRegion { get; set; }
    }
}
