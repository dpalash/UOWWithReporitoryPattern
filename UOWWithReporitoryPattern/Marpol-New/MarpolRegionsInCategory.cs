namespace UOWWithReporitoryPattern.Marpol_New
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MarpolRegionsInCategory")]
    public partial class MarpolRegionsInCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual MarpolCategory MarpolCategory { get; set; }

        public virtual MarpolRegion MarpolRegion { get; set; }
    }
}
