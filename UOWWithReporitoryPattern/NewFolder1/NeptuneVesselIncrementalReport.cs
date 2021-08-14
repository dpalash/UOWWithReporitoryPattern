namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NeptuneVesselIncrementalReport
    {
        public int ID { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string ReportData { get; set; }

        public DateTime? ReportDate { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? LastUpdated { get; set; }

        public int ReportType { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
