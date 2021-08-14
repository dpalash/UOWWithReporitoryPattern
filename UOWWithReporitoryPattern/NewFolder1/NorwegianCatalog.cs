namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NorwegianCatalog")]
    public partial class NorwegianCatalog
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProdId { get; set; }

        [StringLength(50)]
        public string NauProdId { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [StringLength(50)]
        public string ISBN { get; set; }

        public decimal? Price { get; set; }

        public int? CategoryId { get; set; }

        public int? LanguageId { get; set; }

        public int? MediaTypeId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }

        public virtual MediaType MediaType { get; set; }
    }
}
