namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublicationDocumentsIndexInfo")]
    public partial class PublicationDocumentsIndexInfo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NauProdId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProdId { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string RelativePath { get; set; }

        public DateTime? IndexDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
