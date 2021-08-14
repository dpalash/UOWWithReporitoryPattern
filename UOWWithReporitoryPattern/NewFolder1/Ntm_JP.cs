namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ntm_JP
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NMNumber { get; set; }

        public int? Week { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string ChartNumber { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StartPage { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EndPage { get; set; }

        [StringLength(25)]
        public string LastNtm { get; set; }

        public string DocumentPath { get; set; }

        public string TracingsPath { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IssuerID { get; set; }

        public DateTime? Published { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime Added { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
