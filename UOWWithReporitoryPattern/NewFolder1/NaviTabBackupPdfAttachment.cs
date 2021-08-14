namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NaviTabBackupPdfAttachment")]
    public partial class NaviTabBackupPdfAttachment
    {
        public int Id { get; set; }

        public int CustomerInfoId { get; set; }

        public int BackupId { get; set; }

        public int? LastViewedPage { get; set; }

        public int? LastUsedToolType { get; set; }

        public int? LastUsedLayout { get; set; }

        [StringLength(50)]
        public string LastUsedAnnotationColor { get; set; }

        [StringLength(50)]
        public string LastUsedHighlightColor { get; set; }

        public double? LastUsedZoomLevel { get; set; }

        public int? IsInkToolAsBrush { get; set; }

        public string AnnotationXml { get; set; }

        public string BookmarkText { get; set; }

        public string BookmarkTextXml { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int? PublicaitonId { get; set; }

        public int? PublicationDocId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string NauProdId { get; set; }

        [StringLength(50)]
        public string ProdId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual NaviTabBackupCustomerInfo NaviTabBackupCustomerInfo { get; set; }
    }
}
