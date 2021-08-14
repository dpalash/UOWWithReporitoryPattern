namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PublicationDocument
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NauProdId { get; set; }

        [StringLength(50)]
        public string ProdId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "ntext")]
        public string RelativePath { get; set; }

        public int? MaxPrintCount { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DateAdded { get; set; }

        public long? FileSize { get; set; }

        public int? MaxPercentagePrintAllowed { get; set; }

        public int? ProductGroupId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual ProductGroup ProductGroup { get; set; }
    }
}
