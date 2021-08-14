namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_server
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public byte type { get; set; }

        [StringLength(50)]
        public string program { get; set; }

        [Required]
        [StringLength(255)]
        public string value { get; set; }

        [StringLength(50)]
        public string server { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
