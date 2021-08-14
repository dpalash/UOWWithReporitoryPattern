namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselZone
    {
        public int ID { get; set; }

        public int? CustomerId { get; set; }

        public int? FlatFeeZoneId { get; set; }

        public DateTime? DateAdded { get; set; }

        public bool? IsPrimaryZone { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual FlatFeeZone FlatFeeZone { get; set; }
    }
}
