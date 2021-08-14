namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_package
    {
        [Key]
        [StringLength(25)]
        public string sessionid { get; set; }

        public int? customerid { get; set; }

        [StringLength(25)]
        public string status { get; set; }

        [Column(TypeName = "text")]
        public string arguments { get; set; }

        public int? size { get; set; }

        public int? files { get; set; }

        public int? ntms { get; set; }

        public DateTime? date { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
