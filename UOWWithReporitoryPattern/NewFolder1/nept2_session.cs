namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_session
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        [Required]
        [StringLength(25)]
        public string sessionid { get; set; }

        public int customer { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }

        public byte type { get; set; }

        public byte state { get; set; }

        [Required]
        [StringLength(255)]
        public string value { get; set; }

        [StringLength(50)]
        public string server { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
