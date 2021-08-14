namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USCorrection
    {
        public long Id { get; set; }

        [StringLength(15)]
        public string ChartNumber { get; set; }

        [StringLength(50)]
        public string IntlChartNumber { get; set; }

        public short? ChartEdition { get; set; }

        [StringLength(8)]
        public string ChartEditionDate { get; set; }

        [StringLength(6)]
        public string LastNm { get; set; }

        public short Year { get; set; }

        public byte Week { get; set; }

        public bool IsOriginalUSSource { get; set; }

        public bool IsTemporary { get; set; }

        public bool IsPreliminary { get; set; }

        public bool IsLimitedDistribution { get; set; }

        public bool IsMetricOnly { get; set; }

        public bool IsNewChart { get; set; }

        public bool IsNewEdition { get; set; }

        public string Source { get; set; }

        [Column(TypeName = "ntext")]
        public string Entries { get; set; }

        public string TracingsPath { get; set; }

        public string BlocksPath { get; set; }

        public DateTime AddedDate { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
