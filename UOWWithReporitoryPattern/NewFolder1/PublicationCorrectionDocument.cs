namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PublicationCorrectionDocument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PublicationCorrectionDocument()
        {
            ImoPublicationCorrections = new HashSet<ImoPublicationCorrection>();
        }

        public int Id { get; set; }

        [StringLength(25)]
        public string PubProductId { get; set; }

        public int IssuerId { get; set; }

        [StringLength(250)]
        public string CorrectionTitle { get; set; }

        [Required]
        [StringLength(25)]
        public string Language { get; set; }

        [Required]
        public string FilePath { get; set; }

        public DateTime? CorrectionDateUtc { get; set; }

        public DateTime AddedDateUtc { get; set; }

        public DateTime? MappedDateUtc { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImoPublicationCorrection> ImoPublicationCorrections { get; set; }

        public virtual issuer issuer { get; set; }
    }
}
