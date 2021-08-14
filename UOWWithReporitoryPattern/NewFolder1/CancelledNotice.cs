namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CancelledNotice
    {
        [Key]
        [Column("_Id")]
        public long C_Id { get; set; }

        [Column("_NMNumber")]
        public int C_NMNumber { get; set; }

        [Column("_Year")]
        public int C_Year { get; set; }

        [Column("_GeographicalArea")]
        public int C_GeographicalArea { get; set; }

        [Column("_ChartNumber")]
        [StringLength(50)]
        public string C_ChartNumber { get; set; }

        [Column("_IssuerID")]
        public int C_IssuerID { get; set; }

        [Column("_NTMId")]
        public long? C_NTMId { get; set; }

        [Column("_CancelledYear")]
        public int C_CancelledYear { get; set; }

        [Column("_CancelledWeek")]
        public int C_CancelledWeek { get; set; }

        [Column("_Added")]
        public DateTime C_Added { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
