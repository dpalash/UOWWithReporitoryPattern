namespace UOWWithReporitoryPattern.Voyage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RequiredEncsForVoyage")]
    public partial class RequiredEncsForVoyage
    {
        [StringLength(50)]
        public string Id { get; set; }

        public int? EncCellId { get; set; }

        public int VoyageId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        [Required]
        [StringLength(100)]
        public string EncCellName { get; set; }

        public DateTime? ChangedDate { get; set; }

        public int? NaviPlannerUserId { get; set; }

        public virtual EncCell EncCell { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
