namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EncCellReplacement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OriginalCellId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReplacementCellId { get; set; }

        public DateTime? ReplacedDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual EncCell EncCell { get; set; }

        public virtual EncCell EncCell1 { get; set; }
    }
}
