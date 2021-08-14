namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_files
    {
        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string sessionid { get; set; }

        public DateTime start { get; set; }

        public DateTime? finished { get; set; }

        [Required]
        [StringLength(15)]
        public string ip { get; set; }

        public int customer { get; set; }

        [Required]
        [StringLength(300)]
        public string filename { get; set; }

        public int filesize { get; set; }

        public int resumefrom { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
