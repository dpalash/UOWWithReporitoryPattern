namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarpolRegionsInAnnex")]
    public partial class MarpolRegionsInAnnex
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AnnexId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual MarpolAnnex MarpolAnnex { get; set; }

        public virtual MarpolRegion MarpolRegion { get; set; }
    }
}
