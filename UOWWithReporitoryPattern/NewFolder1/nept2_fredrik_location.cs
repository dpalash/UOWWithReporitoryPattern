namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nept2_fredrik_location
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        public string loc { get; set; }

        public DateTime added { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
