namespace UOWWithReporitoryPattern.Customer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselPosition
    {
        public double Lat { get; set; }

        public double Lon { get; set; }

        [Column(TypeName = "xml")]
        public string Data { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime TimestampUtc { get; set; }

        public bool IsWithinCoverage { get; set; }

        public DateTime DateAdded { get; set; }

        public int ProviderId { get; set; }

        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastConfirmedUtc { get; set; }

        public int? CustomerId { get; set; }

        public int? VesselPositionStatusId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }

        public virtual customer customer { get; set; }

        public virtual PositionProvider PositionProvider { get; set; }
    }
}
