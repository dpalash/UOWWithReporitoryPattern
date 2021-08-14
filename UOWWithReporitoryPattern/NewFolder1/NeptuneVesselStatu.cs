namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NeptuneVesselStatu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Column(TypeName = "xml")]
        public string Data { get; set; }

        [Column(TypeName = "xml")]
        public string NP234Report { get; set; }

        public DateTime LastUpdated { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
