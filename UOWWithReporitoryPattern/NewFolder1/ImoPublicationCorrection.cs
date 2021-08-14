namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImoPublicationCorrection")]
    public partial class ImoPublicationCorrection
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProdId { get; set; }

        public int CorrectionDocId { get; set; }

        public int? Volume { get; set; }

        public int PublicationStartPage { get; set; }

        public int PublicationEndPage { get; set; }

        public int CorrectionStartPage { get; set; }

        public int CorrectionEndPage { get; set; }

        public int PublicationActualStartPage { get; set; }

        public int PublicationActualEndPage { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual PublicationCorrectionDocument PublicationCorrectionDocument { get; set; }
    }
}
