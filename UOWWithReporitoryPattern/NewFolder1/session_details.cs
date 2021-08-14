namespace UOWWithReporitoryPattern.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class session_details
    {
        public int id { get; set; }

        public int? sid { get; set; }

        public short? type { get; set; }

        public short? state { get; set; }

        [Column(TypeName = "text")]
        public string value { get; set; }

        public DateTime? date { get; set; }

        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
