namespace UOWWithReporitoryPattern.Voyage
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VoyageRoute")]
    public partial class VoyageRoute
    {
        [StringLength(50)]
        public string Id { get; set; }

        public decimal? Lat { get; set; }

        public decimal? Lon { get; set; }

        public int VoyageId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual Voyage Voyage { get; set; }
    }
}
