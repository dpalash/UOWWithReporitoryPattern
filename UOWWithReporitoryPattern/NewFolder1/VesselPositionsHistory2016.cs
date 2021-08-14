namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VesselPositionsHistory2016
    {
        [Key]
        [Column(Order = 0)]
        public double Lat { get; set; }

        [Key]
        [Column(Order = 1)]
        public double Lon { get; set; }

        [Column(TypeName = "xml")]
        public string Data { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime TimestampUtc { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsWithinCoverage { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime DateAdded { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProviderId { get; set; }

        [Key]
        [Column(Order = 6)]
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastConfirmedUtc { get; set; }

        public int? CustomerId { get; set; }

        public int? VesselPositionStatusId { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
