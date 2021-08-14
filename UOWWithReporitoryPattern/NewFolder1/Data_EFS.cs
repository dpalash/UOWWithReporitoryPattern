namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_EFS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string ChartNumber { get; set; }

        public int NMNumber { get; set; }

        public int Year { get; set; }

        public int Week { get; set; }

        public string Path { get; set; }

        public string GraphicsPath { get; set; }

        public int StartPage { get; set; }

        public int? EndPage { get; set; }

        public DateTime Added { get; set; }

        public int IssuerID { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(15)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
