namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselCompanyFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VesselCompanyFile()
        {
            VesselCompanyFileAccesses = new HashSet<VesselCompanyFileAccess>();
        }

        [Key]
        public int FileId { get; set; }

        public int? TypeId { get; set; }

        public int? CategoryId { get; set; }

        public int GroupId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Language { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        [StringLength(50)]
        public string NauProdId { get; set; }

        [StringLength(50)]
        public string ProdId { get; set; }

        [Required]
        [StringLength(250)]
        public string FileName { get; set; }

        public long FileSize { get; set; }

        [StringLength(100)]
        public string ThumbnailName { get; set; }

        public DateTime UploadedDate { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [StringLength(50)]
        public string ApprovedBy { get; set; }

        public int? MaxPrintCount { get; set; }

        public int? MaxPercentagePrintAllowed { get; set; }

        public int? LanguageId { get; set; }

        public int? MediaTypeId { get; set; }

        public string OriginalFileName { get; set; }

        public string OriginalThumbnailName { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Language Language1 { get; set; }

        public virtual MediaType MediaType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VesselCompanyFileAccess> VesselCompanyFileAccesses { get; set; }

        public virtual VesselCompanyFileType VesselCompanyFileType { get; set; }

        public virtual VesselCompanyPublicationCategory VesselCompanyPublicationCategory { get; set; }
    }
}
