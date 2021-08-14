namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncCell
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncCell()
        {
            EncCellCustomerPaysAreas = new HashSet<EncCellCustomerPaysArea>();
            EncCellCustomerPermits = new HashSet<EncCellCustomerPermit>();
            EncCellReplacements = new HashSet<EncCellReplacement>();
            EncCellReplacements1 = new HashSet<EncCellReplacement>();
            EncCellsInEncProducts = new HashSet<EncCellsInEncProduct>();
        }

        public int Id { get; set; }

        public int IssuerId { get; set; }

        [Required]
        [StringLength(8)]
        public string CellName { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public byte NavigationalPurpose { get; set; }

        public decimal BoundarySLat { get; set; }

        public decimal BoundaryWLon { get; set; }

        public decimal BoundaryNLat { get; set; }

        public decimal BoundaryELon { get; set; }

        public string PolygonPoints { get; set; }

        public short BaseEdition { get; set; }

        public DateTime BaseIssueDate { get; set; }

        public short? LatestUpdateNumber { get; set; }

        public DateTime? RecordLastUpdated { get; set; }

        public DateTime? AddedDate { get; set; }

        public string GeometryData { get; set; }

        public DateTime? ReleaseDateUtc { get; set; }

        public DateTime? CancelDateUtc { get; set; }

        public DateTime? ReplaceDateUtc { get; set; }

        public DbGeography Geography { get; set; }

        public int? DownloadedBaseEdition { get; set; }

        public int? DownloadedUpdateNumber { get; set; }

        public DateTime? DownloadedUtcDate { get; set; }

        public DbGeometry Geometry { get; set; }

        public int? DownloadedIhoBaseEdition { get; set; }

        public int? DownloadedIhoUpdateNumber { get; set; }

        public DateTime? DownloadedIhoUtcDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsForSale { get; set; }

        [StringLength(10)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPaysArea> EncCellCustomerPaysAreas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellCustomerPermit> EncCellCustomerPermits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellReplacement> EncCellReplacements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellReplacement> EncCellReplacements1 { get; set; }

        public virtual issuer issuer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncCellsInEncProduct> EncCellsInEncProducts { get; set; }
    }
}
