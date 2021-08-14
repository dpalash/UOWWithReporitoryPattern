namespace UOWWithReporitoryPattern.Voyage
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
            MissingEncsForVoyages = new HashSet<MissingEncsForVoyage>();
            OutdatedEncsForVoyages = new HashSet<OutdatedEncsForVoyage>();
            RequiredEncsForVoyages = new HashSet<RequiredEncsForVoyage>();
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

        public virtual issuer issuer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MissingEncsForVoyage> MissingEncsForVoyages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutdatedEncsForVoyage> OutdatedEncsForVoyages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredEncsForVoyage> RequiredEncsForVoyages { get; set; }
    }
}
