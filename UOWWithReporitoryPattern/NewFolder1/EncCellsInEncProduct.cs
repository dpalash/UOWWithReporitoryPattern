namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncCellsInEncProduct")]
    public partial class EncCellsInEncProduct
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EncProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EncCellId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncCell EncCell { get; set; }

        public virtual EncProduct EncProduct { get; set; }
    }
}
